namespace cGisDashBoard.Models.Entities
{
    public class IndicadoresDadosTecnicos
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public double Extensao { get; set; }
        public string TipoDado { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public double Diametro { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string Regiao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
