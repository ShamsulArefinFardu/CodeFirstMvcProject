using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstMvcProject_Arefin.Models
{
    public class CustomerRegistraion
    {
        public int CustomerRegistraionID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name Should Be In Between 3-30 Character")]
        [Display(Name = "Full Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Required")]

        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]

        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }


        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Space is not allowed is Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password Not Matched")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }


    }
}