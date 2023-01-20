using cGisDashBoard.Models.DTOs.Genericos;
using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cGisDashBoard.Models.Mapping.IndicadoresOrdemServico
{
    public class OrdemServicoFiltroPorNaturezaMapping: IEntityTypeConfiguration<NaturezaOrdemServico>
    {
        public void Configure(EntityTypeBuilder<NaturezaOrdemServico> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Natureza).HasColumnName("Natureza");
        }
    }
}
