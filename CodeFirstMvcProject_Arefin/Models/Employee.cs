using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstMvcProject_Arefin.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Join Date")]
        public string Date { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/img.png";
        }
    }
}