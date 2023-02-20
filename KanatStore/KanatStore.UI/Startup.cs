//var builder = WebApplication.CreateBuilder(args);

using KanatStore.BLL.Categories.Services;
using KanatStore.BLL.Product.Services;
using KanatStore.DAL;
using Microsoft.EntityFrameworkCore;
using KanatStore.BLL.Store.Service;
using KanatStore.BLL.Employees.Service;
using KanatStore.BLL.Employee.Service;

namespace KanatStore.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuraion = configuration;
        }

        public IConfiguration Configuraion { get; }

        //Phương thức này được gọi bởi thời gian thực. Method này được dùng để thêm services vào container
        public void ConfigureServices(IServiceCollection services)
        {
            //added for session state
            services.AddDistributedMemoryCache();

            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(10);
            });
            services.AddControllersWithViews();

            //Removes the required attribute for non-nullable reference types.
            services.AddControllers(
            options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

            var connectionString = Configuraion.GetConnectionString("DatabaseInfor");
            services.AddDbContext<KanatStoreDBContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRespository, ProductRepository>();
            services.AddScoped<ICategoryRespository, CategoryRespository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        //Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}