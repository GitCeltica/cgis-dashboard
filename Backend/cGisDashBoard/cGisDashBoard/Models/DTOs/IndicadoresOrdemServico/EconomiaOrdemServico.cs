using cGisDashBoard.Models.DTOs.Genericos;

namespace cGisDashBoard.Models.DTOs.IndicadoresOrdemServico
{
    public class EconomiaOrdemServico
    {

        public int CidadeId { get; set; }
        public Decimal ValorEconomia { get; set; }

        public string Natureza { get; set; } = string.Empty;

        public string Equipe { get; set; } = string.Empty;

        public int Mes { get; set; }

        public int Ano { get; set; }
    }
}
