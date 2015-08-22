using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceLibraryDLL
{
    /// <summary>
    /// Class that contain finance data
    /// Implements IFinanceDataService
    /// </summary>
    public class FinanceData : IFinanceDataService
    {
        /// <summary>
        /// Constructor of FinanceData
        /// </summary>
        /// <param name="symbol">Finance symbol in upper letters</param>
        /// <param name="companyName">Company name of symbol given</param>
        /// <param name="currentValue">Finance current value</param>
        /// <param name="change">Finance change value</param>
        /// <param name="percentChange">Percent change of finance</param>
        /// <param name="lastTradeTime">Hour of last trade time</param>
        /// <param name="lastTradeDate">Date of last trade time</param>
        private FinanceData(string symbol, string companyName, double currentValue, double change, string percentChange,
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


        public string symbol { get; set; }
        public string companyName { get; set; }
        public double currentValue { get; set; }
        public double change { get; set; }
        public string percentChange { get; set; }
        public string lastTradeTime { get; set; }
        public string lastTradeDate { get; set; }

        /// <summary>
        /// Default constructor of FinanceData
        /// </summary>
        public FinanceData()
        {

        }

        /// <summary>
        /// FinanceData implements GetFinanceDataService 
        /// </summary>
        /// <param name="companySymbol">Company name of symbol given</param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {
            return FinanceDataImport.Instance.GetFinanceDataService(companySymbol);
        }


    }
}
