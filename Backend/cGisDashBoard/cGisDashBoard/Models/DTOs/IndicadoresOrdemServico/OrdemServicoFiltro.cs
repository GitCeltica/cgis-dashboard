namespace cGisDashBoard.Models.DTOs.IndicadoresOrdemServico
{
    public class OrdemServicoFiltro
    {
        public List<string> Natureza { get; set; }

        public List<string> Equipe { get; set; }
        public List<int> Mes { get; set; }
        public List<int> Ano { get; set; }


        public OrdemServicoFiltro()
        {
            Natureza = new List<string>();
            Equipe = new List<string>();
            Mes = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Ano = new List<int>();

        }
    }
}
