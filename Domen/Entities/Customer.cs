using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Domen.Entities
{
    public class Customer
    {
        [Required(ErrorMessage = "Id is required.")]
        [Key, HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "3 < Name < 255")]
        [Required(ErrorMessage = "Name is required.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public String Address { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "3 < Login < 32")]
        [Required(ErrorMessage = "Login is required.")]
        public String Login { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "3 < Password < 50")]
        [Required(ErrorMessage = "Password is required.")]
        public String Password { get; set; }
    }
}
