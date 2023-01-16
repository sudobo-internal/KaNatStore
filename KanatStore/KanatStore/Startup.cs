//var builder = WebApplication.CreateBuilder(args);

using Microsoft.EntityFrameworkCore;
using KanatStore.Models;
using WebApplication2.Models;

namespace KanatStore
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

            var connectionString = Configuraion.GetConnectionString("DatabaseInfor");
            services.AddDbContext<KanatStoreDBContext>(options => options.UseSqlServer(connectionString));
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
                    pattern: "{controller=Products}/{action=Index}/{id?}");
            });
        }
    }
}