using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Please Enter a Valid Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Please Enter a Valid Name")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 5)]
        public string Password { get; set; }


    }
}