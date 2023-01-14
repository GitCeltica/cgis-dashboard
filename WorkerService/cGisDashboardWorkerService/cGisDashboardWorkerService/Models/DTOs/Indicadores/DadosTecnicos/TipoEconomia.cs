using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cGisDashboardWorkerService.Models.DTOs.Indicadores.DadosTecnicos
{
    public class TipoEconomia
    {
        public int Domiciliar { get; set; }
        public int Comercial { get; set; }
        public int Industrial { get; set; }

        public int Publica { get; set; }
    }
}
