using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Ration of finance data
    /// </summary>
    class Ratio
    {
        float peRatio { get; set; }
        float pegRatio { get; set; }
        float shortRatio { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pe">PE ratio</param>
        /// <param name="peg">PEG ratio</param>
        /// <param name="shortR">short ratio</param>
        public Ratio(float pe, float peg, float shortR)
        {
            peRatio = pe;
            pegRatio = peg;
            shortRatio = shortR;
        }

        /// <summary>
        /// ToString override function
        /// </summary>
        /// <returns>Description string</returns>
        public override string ToString()
        {
            return "PE: " + peRatio + ", PEG: " + pegRatio + ", short: " + shortRatio;
        }
    }
}
