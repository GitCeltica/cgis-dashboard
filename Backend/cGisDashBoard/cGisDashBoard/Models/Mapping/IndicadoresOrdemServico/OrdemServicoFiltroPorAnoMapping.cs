using cGisDashBoard.Models.DTOs.Genericos;
using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cGisDashBoard.Models.Mapping.IndicadoresOrdemServico
{
    public class OrdemServicoFiltroPorAnoMapping: IEntityTypeConfiguration<Ano>
    {
        public void Configure(EntityTypeBuilder<Ano> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Valor).HasColumnName("Ano");
        }
    }
}
