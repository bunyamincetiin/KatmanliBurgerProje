using KatmanliBurger_DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class MenuByProductMapping : BaseEntitiy
    {
        public int MenuId { get; set; }
        public int ByProductId { get; set; }

        //nav
        public virtual Menu Menu { get; set; }
        public virtual ByProduct ByProduct { get; set; }
    }
}
