using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cGisDashBoard.Models.Mapping.IndicadoresOrdemServico
{
    public class MaterialGastoMapping : IEntityTypeConfiguration<MaterialGasto>
    {
        public void Configure(EntityTypeBuilder<MaterialGasto> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.CidadeId).HasColumnName("CidadeId");
            builder.Property(v => v.QuantidadeMaterial).HasColumnName("QuantidadeMaterial");
            builder.Property(v => v.Material).HasColumnName("Valor");
            builder.Property(v => v.Natureza).HasColumnName("Natureza");
            builder.Property(v => v.Equipe).HasColumnName("Equipe");
            builder.Property(v => v.Mes).HasColumnName("Mes");
            builder.Property(v => v.Ano).HasColumnName("Ano");
        }
    }
}
