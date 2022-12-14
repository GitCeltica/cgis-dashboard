using cGisDashboard.Entities;
using cGisDashboard.Enums;
using cGisDashboard.Profiles.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserResponseMapping());
        }
        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
