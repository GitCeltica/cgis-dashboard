namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresLigacoes
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public int LigacoesAgua { get; set; }
        public int LigacoesEsgoto { get; set; }
        public double PercEsgotoTratado { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string Regiao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
