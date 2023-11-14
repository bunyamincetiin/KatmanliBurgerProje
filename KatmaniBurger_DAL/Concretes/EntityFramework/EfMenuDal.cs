using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfMenuDal : EfBaseDal<Menu, BurgerDbContext>, IMenuDal
    {
    }
}
