using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    class Eps
    {
        float estimateCurrentYearPrice { get; set; }
        float estimateNextYearPrice { get; set; }

        public Eps(float current, float nextYear)
        {
            estimateCurrentYearPrice = current;
            estimateNextYearPrice = nextYear;
        }
    }
}
