namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresPerda : BaseEntity
    {
        public int CidadeId { get; set; }
        public double? VazamentosKMRDA { get; set; }
        public double? VazamentoLigacoes { get; set; }
        public double? TempoMedioCorrecao { get; set; }
        public double? IdadeMediaHidrometros { get; set; }
        public double? InfracoesConfirmadas { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string? Regiao { get; set; } = string.Empty;
        public DateTime? DataAtualizacao { get; set; }
    }
}
