using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cGisDashboardWorkerService.Models.DTOs.Indicadores.DadosTecnicos
{
    public class ConsumoMedioCliente
    {
        public decimal ConsumoMedio { get; set; }

        public String Situacao { get; set; } = string.Empty;
    }
}
