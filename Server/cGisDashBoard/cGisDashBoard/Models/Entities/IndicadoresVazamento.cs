namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresVazamento : BaseEntity
    {
        public int CidadeId { get; set; }

        public float VazamentosKMRDA { get; set; }

        public float VazamentoLigacoes { get; set; }

        public float TempoMedioCorrecao { get; set; }

        public float IdadeMediaHidrometros { get; set; }

        public int InfracoesConfirmadas { get; set; }

        public string Regiao { get; set; } = string.Empty;
    }
}
