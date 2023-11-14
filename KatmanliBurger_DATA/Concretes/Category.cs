using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.Concretes
{
    public class Category : BaseEntitiy
    {
        public string Name { get; set; }
        public virtual ICollection<ByProduct> ByProducts { get; set; }
    }
}
