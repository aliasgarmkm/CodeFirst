using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int DeptID { get; set; }
        public virtual Department Departments { get; set; }
    }
}