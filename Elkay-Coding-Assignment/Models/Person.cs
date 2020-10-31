using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Elkay_Coding_Assignment.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter a First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter a Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "Please Enter an Address")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? Address2 { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please Enter a City")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please Enter a State")]
        public string State { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please Enter a Country")]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter a Phone Number")]
        public string Phone { get; set; }
    }
}
