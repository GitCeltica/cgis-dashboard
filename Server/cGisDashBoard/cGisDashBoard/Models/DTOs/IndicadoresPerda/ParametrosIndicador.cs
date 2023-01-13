namespace cGisDashBoard.Models.DTOs.IndicadorPerdas
{
    public class ParametrosIndicador
    {
        public int CidadeId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public string? Regiao { get; set; } = string.Empty; 
    }
}
