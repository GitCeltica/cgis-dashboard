
using cGisDashBoard.Models.DTOs.Genericos;
using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadoresOrdemServico;
using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Models.Mapping.Indicadores;
using cGisDashBoard.Models.Mapping.IndicadoresOrdemServico;
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

            modelBuilder.ApplyConfiguration(new PerdasRegiaoMapping());

            modelBuilder.ApplyConfiguration(new OrdemServicoFiltroPorAnoMapping());
            modelBuilder.ApplyConfiguration(new OrdemServicoFiltroPorNaturezaMapping());
            modelBuilder.ApplyConfiguration(new OrdemServicoFiltroPorEquipeMapping());
            modelBuilder.ApplyConfiguration(new RegiaoAfetadaMapping());
            modelBuilder.ApplyConfiguration(new MaterialGastoMapping());
            modelBuilder.ApplyConfiguration(new EconomiaOrdemServicoMapping());

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<IndicadoresPerda> IndicadoresPerdas { get; set; }

        public DbSet<IndicadoresDadosTecnicos> IndicadoresDadosTecnicos { get; set; }

        public DbSet<IndicadoresConsumo> IndicadoresConsumo { get; set; }

        public DbSet<IndicadoresLigacoes> IndicadoresLigacoes { get; set; }

        public DbSet<IndicadoresOrdemServico> IndicadoresOrdemServico { get; set; }

        public DbSet<IndicadoresOrdemServicoRanking> IndicadoresOrdemServicoRanking { get; set; }

        public DbSet<PerdasRegiao> PerdasRegioes { get; set; }

        public DbSet<Ano> ListaAno { get; set; }

        public DbSet<NaturezaOrdemServico> Naturezas { get; set; }

        public DbSet<EquipeOrdemServico> Equipes { get; set; }

        public DbSet<RegiaoAfetada> RegioesAFetadas { get; set; }

        public DbSet<MaterialGasto> MateriaisGastos { get; set;}

        public DbSet<EconomiaOrdemServico> EconomiaPorOrdemServico { get; set; }
        
    }
}
