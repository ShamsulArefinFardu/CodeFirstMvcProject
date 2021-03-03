using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstMvcProject_Arefin.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}