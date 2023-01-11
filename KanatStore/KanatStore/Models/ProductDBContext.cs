using KanatStore.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {

        }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }

        //private const string connectionstring = @"
        //    Data Source=DESKTOP-E8CRG8D\SQLEXPRESS;
        //    Initial Catalog=QLSP;
        //    User ID=sa;
        //    Password=123;
        //    TrustServerCertificate=Yes;";
        //phương thức này chạy khi đối tượng DbContext mới được tạo (ProductDBContext)
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    //thiết lập cấu hình: cho biết làm việc với sqlServer
        //    optionsBuilder.UseSqlServer(connectionstring);

        //}

        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }


    }
}