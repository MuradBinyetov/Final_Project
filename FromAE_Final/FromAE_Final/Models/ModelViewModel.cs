using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class ModelViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public IFormFile MainImg { get; set; }

        public ICollection<Product> Products { get; set; }

        public Marka Marka { get; set; }
        public int MarkaId { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
