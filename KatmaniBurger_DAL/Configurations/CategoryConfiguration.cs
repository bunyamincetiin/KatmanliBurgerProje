using KatmanliBurger_DAL.Configurations.Extensions;
using KatmanliBurger_DATA.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatmanliBurger_DAL.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.AddSeedData();
        }
    }
}
