using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceLibraryDLL
{
    /// <summary>
    /// Interface of finance data services
    /// </summary>
    public interface IFinanceDataService
    {
        /// <summary>
        /// Get finance data service for given symbol
        /// </summary>
        /// <param name="companySymbol">Company finance symbol should contains upper letters only</param>
        /// <returns>IFinanceDataService</returns>
        IFinanceDataService GetFinanceDataService(string companySymbol);

    }
}
