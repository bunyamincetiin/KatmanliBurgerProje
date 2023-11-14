using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class MenuByProduct
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int ByProductId { get; set; }

        //nav
        public Menu Menu { get; set; }
        public ByProduct ByProduct { get; set; }
    }
}
