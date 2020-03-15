using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Models
{
    public class SubMenu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public string Link { get; set; }


        public Menu Menu { get; set; }
        public int MenuId { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
