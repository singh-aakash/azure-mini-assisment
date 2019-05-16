using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//DataAnnotations is requires for validation
using System.Linq;
using System.Web;

namespace BankingApp.Models
{
    public class ProductDetails
    {
        [Key]
        public string Id { get; set; }

        // Validations 
        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50)]
        public string Name { get; set; }
        public string Category { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Product Qty")]
        public int ProdQty { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [RegularExpression(@"\d{4,9}")]
        public string Password { get; set; }
    }
}