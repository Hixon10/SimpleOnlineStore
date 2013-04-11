using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Domen.Entities
{
    public class OrderLine
    {
        [Required(ErrorMessage = "Id is required.")]
        [Key, HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "3 < ProductLength < 255")]
        [Required(ErrorMessage = "Product is required.")]
        public String Product { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Count must be a positive number")]
        [Required(ErrorMessage = "Count is required.")]
        public int Count { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Total must be a positive number")]
        [Required(ErrorMessage = "Total is required.")]
        public double Total { get; set; }

        [Required(ErrorMessage = "IdOrder is required.")]
        public int IdOrder { get; set; }
        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }
    }
}
