using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    class Ratio
    {
        float peRatio { get; set; }
        float pegRatio { get; set; }
        float shortRatio { get; set; }

        public Ratio(float pe, float peg, float shortR)
        {
            peRatio = pe;
            pegRatio = peg;
            shortRatio = shortR;
        }
    }
}
