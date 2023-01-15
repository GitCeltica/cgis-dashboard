using cGisDashBoard.Models.Entities;
using cGisDashBoard.Repositories.Indicadores;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace cGisDashBoard.Helpers.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        { 
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<IndicadoresPerda> IndicadoresPerdas { get; set; }

        public DbSet<IndicadoresDadosTecnicos> IndicadoresDadosTecnicos { get; set; }

        public DbSet<IndicadoresConsumo> IndicadoresConsumo { get; set; }

        public DbSet<IndicadoresLigacoes> IndicadoresLigacoes { get; set; }

        public DbSet<IndicadoresOrdemServico> IndicadoresOrdemServico { get; set; }

        public DbSet<IndicadoresOrdemServicoRanking> IndicadoresOrdemServicoRanking { get; set; }
        
    }
}
