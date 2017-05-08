using Itech.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
namespace Itech.Data
{
    public class ItechDbContext : IdentityDbContext<ApplicationUser>
    {
        public ItechDbContext() : base("ItechShop")
        {
            // khi đã có db hoặc tb thì sẽ ko tạo thêm
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Brand> Brandss { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionDetail> PromotionDetails { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountDetail> DiscountDetails { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Error> Errors { get; set; }

        public static ItechDbContext Create()
        {
            return new ItechDbContext();
        }

        // được ghi đè đẻ có thể thêm hoặc chỉnh sửa database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}