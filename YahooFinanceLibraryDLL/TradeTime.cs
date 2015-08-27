using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    class TradeTime
    {
        string lastDate { get; set; }
        string lastTime { get; set; }

        public TradeTime(string date, string time)
        {
            lastDate = date;
            lastTime = time;
        }
    }
}
