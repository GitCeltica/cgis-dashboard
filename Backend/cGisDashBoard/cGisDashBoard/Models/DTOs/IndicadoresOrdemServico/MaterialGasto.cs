namespace cGisDashBoard.Models.DTOs.IndicadoresOrdemServico
{
    public class MaterialGasto
    {
        public int CidadeId { get; set; }
        public int QuantidadeMaterial { get; set; }

        public string Material { get; set; } = string.Empty;

        public string Natureza { get; set; } = string.Empty;

        public string Equipe { get; set; } = string.Empty;

        public int Mes { get; set; }

        public int Ano { get; set; }
    }
}
