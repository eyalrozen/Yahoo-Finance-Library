using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Class that contain finance data
    /// Implements IFinanceDataService
    /// </summary>
    class FinanceDataClass : FinanceData, IFinanceDataService
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
        public FinanceDataClass(string symbol, string companyName, double currentValue, double change, string percentChange,
            string lastTradeTime, string lastTradeDate)
            : base(symbol, companyName, currentValue, change, percentChange, lastTradeTime, lastTradeDate)
        {
        }

 /*       /// <summary>
        /// Default constructor of FinanceData
        /// </summary>
        public FinanceDataClass() : base("","",0,0,"","","")
        {
            
        } */

        /// <summary>
        /// FinanceData implements GetFinanceDataService 
        /// </summary>
        /// <param name="companySymbol">Company name of symbol given</param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {
            //return FinanceDataServiceFactory();
            return null;
        }
    }
}
