using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using cGisDashBoard.Models.DTOs.IndicadoresPerda;

namespace cGisDashBoard.Models.Mapping.Indicadores
{
    public class PerdasDadosFiltroMapping : IEntityTypeConfiguration<DadosFiltro>
    {
        public void Configure(EntityTypeBuilder<DadosFiltro> builder)
        {
            builder.HasNoKey();
            //builder.Property(v => v.Regiao).HasColumnName("Regiao");
        }
    }
}
