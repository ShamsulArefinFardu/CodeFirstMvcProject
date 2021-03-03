using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstMvcProject_Arefin.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public DateTime EntryDate { get; set; }

        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}