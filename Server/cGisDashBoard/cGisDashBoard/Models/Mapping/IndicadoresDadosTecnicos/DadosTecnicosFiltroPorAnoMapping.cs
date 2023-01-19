using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Models.Mapping.IndicadoresDadosTecnicos
{
    public class DadosTecnicosFiltroPorAnoMapping : IEntityTypeConfiguration<DadosTecnicosAno>
    {
        public void Configure(EntityTypeBuilder<DadosTecnicosAno> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Ano).HasColumnName("Ano");
        }
    }
}
