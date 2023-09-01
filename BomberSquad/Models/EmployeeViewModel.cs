using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomberSquad.Models
{
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string DeptName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LAddressLine1 { get; set; }
        public string LState { get; set; }
        public string LCity { get; set; }
        public string LCountry { get; set; }
        public Nullable<int> LPincode { get; set; }
    }
}