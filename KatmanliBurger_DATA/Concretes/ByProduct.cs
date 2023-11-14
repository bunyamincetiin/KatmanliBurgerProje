using KatmanliBurger_DATA.Abstracts;
using KatmanliBurger_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class ByProduct : BaseEntitiy
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public Size Size { get; set; } = Size.Medium;
        public virtual ICollection<MenuByProductMapping> MenuByProducts { get; set; }
        public virtual ICollection<OrderByProductMapping> OrderByProducts { get; set; }
        public virtual Category Category { get; set; }
    }
}
