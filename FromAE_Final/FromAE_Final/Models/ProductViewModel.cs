using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]

        public decimal Price { get; set; }

        public string Discount { get; set; }
        public string SalePrice { get; set; }

        [Required]
        public IFormFile MainImg { get; set; }

        public Model Model { get; set; }
        public int ModelId { get; set; }

        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
