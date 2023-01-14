using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cGisDashboardWorkerService.Helpers.Utils
{
    public static class cGISFormat
    {
        public static string CommaToDot(double value)
        {
            string res = value.ToString();
            res = res.Replace(',', '.');
            return res;
        }

        public static string CommaToDot(decimal value)
        {
            string res = value.ToString();
            res = res.Replace(',', '.');
            return res;
        }
    }
}
