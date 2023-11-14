using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.Concretes
{
    public class Order : BaseEntitiy
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<BurgerOrderMapping> BurgerOrders { get; set; }
        public virtual ICollection<MenuOrderMapping> MenuOrders { get; set; }
        public virtual ICollection<OrderByProductMapping> OrderByProducts { get; set; }
    }
}
