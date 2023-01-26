namespace cGisDashBoard.Models.DTOs.IndicadoresOrdemServico
{
    public class RegiaoAfetada
    {
        public int CidadeId { get; set; }
        public int QuantidadeOs { get; set; }

        public string Regiao { get; set; } = string.Empty; 

        public string Natureza { get; set; } = string.Empty;

        public string Equipe { get; set; } = string.Empty;

        public int Mes { get; set; }

        public int Ano { get; set; }
    }
}
