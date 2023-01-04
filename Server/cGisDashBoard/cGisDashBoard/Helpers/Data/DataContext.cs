using cGisDashBoard.Models.Entities;
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
    }
}
