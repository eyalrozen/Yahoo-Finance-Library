using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// FinanceData Object - Contains company name, stock symbol, stock current value, change, percent change, last trade time (Date and hour)
    /// </summary>
    public class FinanceData
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public double currentValue { get; set; }
        public double change { get; set; }
        public string percentChange { get; set; }
        public string lastTradeTime { get; set; }
        public string lastTradeDate { get; set; }

        /// <summary>
        /// Constructor for FinanceData
        /// </summary>
        /// <param name="symbol">Stock symbol</param>
        /// <param name="companyName">Company name</param>
        /// <param name="currentValue">Stock value</param>
        /// <param name="change">Change</param>
        /// <param name="percentChange">Change percent</param>
        /// <param name="lastTradeTime">Last trade time hour</param>
        /// <param name="lastTradeDate">Last trade time date</param>
        protected FinanceData(string symbol, string companyName, double currentValue, double change, string percentChange,
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
        /// Print all object values
        /// </summary>
        /// <returns>string description</returns>
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
