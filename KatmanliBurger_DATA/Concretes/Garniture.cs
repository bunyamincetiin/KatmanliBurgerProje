using KatmanliBurger_DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class Garniture : BaseEntitiy
    {
       
        public string Name { get; set; }

        //Nav
        public ICollection<BurgerGarnitureMapping> BurgerGarnitures { get; set; }
    }
}
