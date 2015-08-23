using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceLibraryDLL
{
    /// <summary>
    /// 
    /// </summary>
    public class FinanceDataClass
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public double currentValue { get; set; }
        public double change { get; set; }
        public string percentChange { get; set; }
        public string lastTradeTime { get; set; }
        public string lastTradeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="companyName"></param>
        /// <param name="currentValue"></param>
        /// <param name="change"></param>
        /// <param name="percentChange"></param>
        /// <param name="lastTradeTime"></param>
        /// <param name="lastTradeDate"></param>
        protected FinanceDataClass(string symbol, string companyName, double currentValue, double change, string percentChange,
            string lastTradeTime, string lastTradeDate)
        {
            this.symbol = symbol;
            this.companyName = companyName;
            this.currentValue = currentValue;
            this.change = change;
            this.percentChange = percentChange;
            this.lastTradeTime = lastTradeTime;
            this.lastTradeDate = lastTradeDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string description = "Company name: " + companyName;
            description += "\nSymbol: " + symbol;
            description += "\nCurrent Value: " + currentValue;
            description += "\nChange: " + change;
            description += "\nPercentage Change: " + percentChange;
            description += "\nLast trade time: " + lastTradeDate + " " + lastTradeTime;

            return description;
        }
    }
}
