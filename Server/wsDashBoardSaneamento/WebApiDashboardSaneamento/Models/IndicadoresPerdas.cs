namespace WebApiDashboardSaneamento.Models
{
    public class IndicadoresPerdas
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public double VazamentosKMRDA { get; set; }
        public double VazamentoLigacoes { get; set; }
        public double TempoMedioCorrecao { get; set; }
        public double IdadeMediaHidrometros { get; set; }
        public double InfracoesConfirmadas { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string Regiao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
    public class DadosTecnicos
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public double ExtensaoPorDiametro { get; set; }
        public double ExtensaoPorMaterial { get; set; }
        public double ExtensaoPorTipo { get; set; }
        public double ConsumoMedioPorTipoEconomia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string Regiao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
