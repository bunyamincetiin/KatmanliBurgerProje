using KatmanliBurger_DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class Menu : BaseEntitiy
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int Piece { get; set; } = 1;
        public virtual ICollection<BurgerMenu> BurgerMenus { get; set; }
        public virtual ICollection<MenuOrder> MenuOrders { get; set; }
        public virtual ICollection<MenuByProduct> MenuByProducts { get; set; }
    }
}
