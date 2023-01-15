namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresOrdemServicoRanking
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public string Natureza { get; set; }
        public string Equipe { get; set; }
        public int Quantidade { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
