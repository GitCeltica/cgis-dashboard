using cGisDashboard.Entities;
using cGisDashboard.Enums;
using Microsoft.EntityFrameworkCore;

namespace cGisDashboard.Helpers
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        /*

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .Property(e => e.Type)
                .HasConversion(
                       v => v.ToString(),
                       v => (TypeUser)Enum.Parse(typeof(TypeUser), v)
                    );
        }*/

        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
