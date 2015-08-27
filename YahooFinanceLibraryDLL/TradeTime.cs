using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Trade time of finance data
    /// </summary>
    class TradeTime
    {
        string lastDate { get; set; }
        string lastTime { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="date">Last trade date</param>
        /// <param name="time">Last trade time</param>
        public TradeTime(string date, string time)
        {
            lastDate = date;
            lastTime = time;
        }

        /// <summary>
        /// To string override
        /// </summary>
        /// <returns>Description string</returns>
        public override string ToString()
        {
            return "Last date: " + lastDate + ", last time: " + lastTime;
        }
    }
}
