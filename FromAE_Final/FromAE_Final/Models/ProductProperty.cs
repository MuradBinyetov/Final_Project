using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class ProductProperty
    {
        public string Value { get; set; }

        public Product Product { get; set; }
        public Property Property { get; set; }

        public int ProductId { get; set; }
        public int PropertyId { get; set; }
    }
}
