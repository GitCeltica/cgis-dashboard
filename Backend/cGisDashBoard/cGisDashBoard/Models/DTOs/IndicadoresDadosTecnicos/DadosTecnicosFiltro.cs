namespace cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos
{
    public class DadosTecnicosFiltro
    {

        public List<int> Mes { get; set; }
        public List<int> Ano { get; set; }

        public DadosTecnicosFiltro()
        {
            Mes = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Ano = new List<int>();

        }
    }
}
