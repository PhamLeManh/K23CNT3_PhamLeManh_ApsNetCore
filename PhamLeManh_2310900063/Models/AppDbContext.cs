using Microsoft.EntityFrameworkCore;
using PhamLeManh_2310900063.Models;

namespace PhamLeManh_2310900063.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PlmEmployee> PlmEmployees { get; set; }
    }
}
