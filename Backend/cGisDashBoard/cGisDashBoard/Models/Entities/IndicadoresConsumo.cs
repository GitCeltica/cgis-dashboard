namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresConsumo
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public double ConsumoMedio { get; set; }
        public int Ligacoes { get; set; }
        public string Tipo { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string Regiao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
