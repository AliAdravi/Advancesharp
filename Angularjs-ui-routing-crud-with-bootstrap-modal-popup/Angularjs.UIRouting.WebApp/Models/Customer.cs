using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Angularjs.UIRouting.WebApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Country { get; set; }
        public string Image { get; set; }
    }

    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }


}