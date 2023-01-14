using cGisDashboardWorkerService.Helpers.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cGisDashboardWorkerService.Workers.Indicadores.Interfaces
{
    public interface IDadosTecnicos
    {
        public Task<DebugInfoResult> ProcessaDadosTecnicos();
    }
}
