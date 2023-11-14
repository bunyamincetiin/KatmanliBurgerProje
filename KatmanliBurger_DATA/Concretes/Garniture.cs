using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.Concretes
{
    public class Garniture : BaseEntitiy
    {
       
        public string Name { get; set; }

        //Nav
        public ICollection<BurgerGarnitureMapping> BurgerGarnitures { get; set; }
    }
}
