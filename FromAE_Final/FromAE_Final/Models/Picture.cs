using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class Picture
    {
        public int id { get; set; }

        public string Images { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
