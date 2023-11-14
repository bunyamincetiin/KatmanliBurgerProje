using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.Concretes
{
    public class BurgerGarnitureMapping : BaseEntitiy
    {
        public int BurgerId { get; set; }
        public int GarnitureId { get; set; }


        //:Navigation prop
        public virtual Burger Burger { get; set; }
        public virtual Garniture Garniture { get; set; }
    }
}
