using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Models.Mapping.Indicadores;
using cGisDashBoard.Models.Mapping.IndicadoresDadosTecnicos;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PerdasAnoMapping());
            modelBuilder.ApplyConfiguration(new PerdasRegiaoMapping());

            modelBuilder.ApplyConfiguration(new DadosTecnicosFiltroPorAnoMapping());

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<IndicadoresPerda> IndicadoresPerdas { get; set; }

        public DbSet<IndicadoresDadosTecnicos> IndicadoresDadosTecnicos { get; set; }

        public DbSet<IndicadoresConsumo> IndicadoresConsumo { get; set; }

        public DbSet<IndicadoresLigacoes> IndicadoresLigacoes { get; set; }

        public DbSet<IndicadoresOrdemServico> IndicadoresOrdemServico { get; set; }

        public DbSet<IndicadoresOrdemServicoRanking> IndicadoresOrdemServicoRanking { get; set; }

        public DbSet<PerdasAno> PerdasAnos { get; set; }

        public DbSet<PerdasRegiao> PerdasRegioes { get; set; }

        public DbSet<DadosTecnicosAno> DadosTecnicosAnos { get; set; }
        
    }
}
