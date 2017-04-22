using Itech.Model.Models;
using System.Data.Entity;

namespace Itech.Data
{
    public class ItechDbContext : DbContext
    {
        public ItechDbContext() : base("ItechShop")
        {
            // khi đã có db hoặc tb thì sẽ ko tạo thêm
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Brand> Brandss { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberCategory> MemberCategorys { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionDetail> PromotionDetails { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}