using KatmanliBurger_DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliBurger_DATA.Concretes
{
    public class Category : BaseEntitiy
    {
        public string Name { get; set; }
        public virtual ICollection<ByProduct> ByProducts { get; set; }
    }
}
