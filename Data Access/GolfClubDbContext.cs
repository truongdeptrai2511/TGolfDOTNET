using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using TGolf.Model;

namespace TGolf.Data_Access
{
    public class GolfClubDbContext : DbContext
    {
        public GolfClubDbContext(DbContextOptions<GolfClubDbContext> options) : base(options)
        {
        }

        // Khai báo các DbSet tương ứng với các bảng trong cơ sở dữ liệu
        public DbSet<Member> Members { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BagNo> BagNos { get; set; }
        public DbSet<Caddy> Caddies { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<ProShopItem> ProShopItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        // Override phương thức OnModelCreating để tùy chỉnh các quan hệ và cấu trúc bảng
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProShopItem>().HasNoKey();
            // Các cấu hình và mapping khác
        }

    }
}
