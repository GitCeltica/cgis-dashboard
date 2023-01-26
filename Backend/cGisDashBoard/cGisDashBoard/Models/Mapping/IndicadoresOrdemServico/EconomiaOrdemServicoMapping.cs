using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Models.Mapping.IndicadoresOrdemServico
{
    public class EconomiaOrdemServicoMapping: IEntityTypeConfiguration<EconomiaOrdemServico>
    {
        public void Configure(EntityTypeBuilder<EconomiaOrdemServico> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.CidadeId).HasColumnName("CidadeId");
            builder.Property(v => v.ValorEconomia).HasColumnName("ValorEconomia");
            builder.Property(v => v.Natureza).HasColumnName("Natureza");
            builder.Property(v => v.Equipe).HasColumnName("Equipe");
            builder.Property(v => v.Mes).HasColumnName("Mes");
            builder.Property(v => v.Ano).HasColumnName("Ano");
        }
    }
}
