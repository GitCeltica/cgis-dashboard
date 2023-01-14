namespace cGisDashBoard.Models.DTOs.IndicadorPerdas
{
    public class ParametrosIndicador
    {
        public int CidadeId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public string Regiao { get; set; } 
    }

    public class ParametrosIndicadorOS
    {
        public int CidadeId { get; set; }
        public string Natureza { get; set; }
        public string Equipe { get; set; }
        public int Mes { get; set; }

        public int Ano { get; set; }
    }
}
