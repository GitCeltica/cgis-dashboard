namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresOrdemServico
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public int QtdOS { get; set; }
        public int QtdOSPrazo { get; set; }
        public int QtdOSForaPrazo { get; set; }
        public double CustoMedio { get; set; }
        public double DistanciaMedia { get; set; }
        public double TempoMedio { get; set; }
        public string Natureza { get; set; }
        public string Equipe { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
