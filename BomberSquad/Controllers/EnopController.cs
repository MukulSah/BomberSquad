using BomberSquad.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace BomberSquad.Controllers
{
    public class EnopController : Controller
    {
        //private readonly HttpClient _httpClient;
        //public  ApiService()
        //{ 
        //    _httpClient = new HttpClient();
        //    _httpClient.BaseAddress = new Uri("http://localhost:51236/api/omnie/v1/");
        //}
           
        
        // GET: Enop
        public ActionResult EmployeeDetails()
        {
            IEnumerable<EmployeeViewModel> employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51236/api/omnie/v1/");
                //HTTP GET
                var responseTask = client.GetAsync("get");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<EmployeeViewModel>>();
                    readTask.Wait();

                    employee = readTask.Result;
                }

            }
            return View(employee);
        }

          public ActionResult create()
            {
            return View();
            }
 
        [HttpPost]
        public ActionResult create(CreateAccount employee)
        {
            if (!ModelState.IsValid) 
            {
                return View(employee); 
            }
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:51236/api/omnie/v1/");
                try
                {
                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<CreateAccount>("create", employee);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                   return RedirectToAction("EmployeeDetails");
                    }

                }
                catch (HttpRequestException ex)
                {
                    // Handle HTTP request exceptions (e.g., network issues, API unavailable)
                    ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
                }

            }
          
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            CreateAccount employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51236/api/omnie/v1/");
                //HTTP GET
                var responseTask = client.GetAsync("getid/" +id.ToString());
                responseTask.Wait();
                
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<CreateAccount>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
            }

            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(CreateAccount employee)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51236/api/omnie/v1/");
                //HTTP GET
                var PutTask = client.PutAsJsonAsync<CreateAccount>("update", employee);
                PutTask.Wait();

                var result = PutTask.Result;
                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
                return View(employee);
            }
        }



    }
}