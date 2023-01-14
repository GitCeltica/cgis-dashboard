using Microsoft.EntityFrameworkCore;

namespace WebApiDashboardSaneamento.Models
{
    public class DashBoardDbContext : DbContext
    {
        public DbSet<IndicadoresPerdas> IndicadoresPerdas { get; set; }


        public DashBoardDbContext(DbContextOptions<DashBoardDbContext> options) : base(options)
        {
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IndicadoresPerdas>().ToTable("IndicadoresPerdas");
        }
    }
}