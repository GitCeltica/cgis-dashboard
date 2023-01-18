namespace cGisDashBoard.Models.DTOs.IndicadoresPerda
{
    public class DadosFiltro
    {
        public List<int> Mes { get; set; }

        public List<int> Ano { get; set; }
        public List<string> Regioes { get; set;  }    

        public DadosFiltro()
        {
            Mes = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Ano = new List<int>();
            Regioes = new List<string>();

        }
    }
}
