using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Concretes.EntityFramework;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;
using KatmanliBurger_SERVICE.Services.BurgerGarnitureMappingServices;
using KatmanliBurger_SERVICE.Services.BurgerService;
using KatmanliBurger_SERVICE.Services.ByProductServices;
using KatmanliBurger_SERVICE.Services.CategoryServices;
using KatmanliBurger_SERVICE.Services.GarnitureServices;
using KatmanliBurger_SERVICE.Services.MenuServices;
using Microsoft.AspNetCore.Identity;

namespace KatmanliBurger_UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<BurgerDbContext>();
            builder.Services.AddIdentity<AppUser,AppRole>(
                option => 
                {
                    option.Password.RequiredLength = 8;
                    option.Password.RequireUppercase = true;
                    option.Password.RequireLowercase = true;
                    option.Password.RequireNonAlphanumeric = true;
                    option.User.RequireUniqueEmail = true;
                }).AddEntityFrameworkStores<BurgerDbContext>().AddRoleManager<RoleManager<AppRole>>();
            builder.Services.AddScoped<IBurgerService, BurgerManager>();
            builder.Services.AddScoped<IMenuService, MenuManager>();
            builder.Services.AddScoped<IMenuDal, EfMenuDal>();

            builder.Services.AddScoped<IByProductDal, EfByProductDal>();
            builder.Services.AddScoped<IByProductService, ByProductManager>();

            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();



            builder.Services.AddScoped<IBurgerDal, EfBurgerDal>();
            builder.Services.AddScoped<IGarnitureDal, EfGarnitureDal>();
            builder.Services.AddScoped<IGarnitureService, GarnitureManager>();

            builder.Services.AddScoped<IBurgerGarnitureMappingDal, EfBurgerGarnitureMappingDal>();
            builder.Services.AddScoped<IBurgerGarnitureMappingService, BurgerGarnitureMappingManager>();

            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}