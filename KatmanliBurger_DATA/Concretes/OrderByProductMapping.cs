using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.Concretes
{
    public class OrderByProductMapping : BaseEntitiy
    {
        public int ByProductId { get; set; }
        public int OrderId { get; set; }

        //nav
        public virtual Order Order { get; set; }
        public virtual ByProduct ByProduct { get; set; }
    }
}
