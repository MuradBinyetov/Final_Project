using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
