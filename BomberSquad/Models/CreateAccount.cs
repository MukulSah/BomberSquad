using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BomberSquad.Models
{
    public class CreateAccount
    {
        [StringLength(50, MinimumLength = 5)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 5)]
        public string LastName { get; set; }
        [Required]
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        //ErrorMessage = "Please enter correct email address")]
        public string EmailId { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        [Required]
        public Nullable<int> ManagerId { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        [Required]
        public Nullable<int> DeptId { get; set; }
    }
}