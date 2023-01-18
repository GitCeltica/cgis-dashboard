using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Models.Mapping.Indicadores
{
    public class PerdasRegiaoMapping : IEntityTypeConfiguration<PerdasRegiao>
    {
        public void Configure(EntityTypeBuilder<PerdasRegiao> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Regiao).HasColumnName("Regiao");
        }
    }
}
