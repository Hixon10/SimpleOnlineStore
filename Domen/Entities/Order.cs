using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Domen.Entities
{
    public class Order
    {
        [Required(ErrorMessage = "Id is required.")]
        [Key, HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number must be a positive number")]
        [Required(ErrorMessage = "Number is required.")]
        public int Number { get; set; }

        [Required(ErrorMessage = "CreationDate is required.")]
        public DateTime CreationDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Amount must be a positive number")]
        [Required(ErrorMessage = "Amount is required.")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "IdCustomer is required.")]
        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public virtual Customer Customer { get; set; }
    }
}
