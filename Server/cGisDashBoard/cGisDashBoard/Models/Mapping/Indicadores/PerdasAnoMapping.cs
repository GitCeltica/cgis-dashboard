using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Models.Mapping.Indicadores
{
    public class PerdasAnoMapping : IEntityTypeConfiguration<PerdasAno>
    {
        public void Configure(EntityTypeBuilder<PerdasAno> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Ano).HasColumnName("Ano");
        }
    }
}
