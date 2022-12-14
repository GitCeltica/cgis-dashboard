using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using cGisDashboard.Dto.User;

namespace cGisDashboard.Profiles.Mapping
{
    class UserResponseMapping : IEntityTypeConfiguration<UserResponse>
    {
        public void Configure(EntityTypeBuilder<UserResponse> builder)
        {

            builder.HasNoKey();
            builder.Property(p => p.UserName).HasColumnName("UserName");
            builder.Property(p => p.FirstName).HasColumnName("FirstName");
            builder.Property(p => p.LastName).HasColumnName("ColumnName");
        }
    }
}
