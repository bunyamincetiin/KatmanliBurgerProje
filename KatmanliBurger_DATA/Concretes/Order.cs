using KatmanliBurger_DATA.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class Order : BaseEntitiy
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<BurgerOrder> BurgerOrders { get; set; }
        public virtual ICollection<MenuOrder> MenuOrders { get; set; }
        public virtual ICollection<OrderByProduct> OrderByProducts { get; set; }
    }
}
