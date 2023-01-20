using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cGisDashBoard.Models.Mapping.IndicadoresOrdemServico
{
    public class OrdemServicoFiltroPorEquipeMapping: IEntityTypeConfiguration<EquipeOrdemServico>
    {
        public void Configure(EntityTypeBuilder<EquipeOrdemServico> builder)
        {
            builder.HasNoKey();
            builder.Property(v => v.Equipe).HasColumnName("Equipe");
        }
    }
}
