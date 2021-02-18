using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }

        public string DeptName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}