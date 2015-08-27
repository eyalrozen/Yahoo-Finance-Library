using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Factory of financeData via given enum
    /// </summary>
    public abstract class FinanceDataServiceFactory : IFinanceDataService
    {
        /// <summary>
        /// Enums that indicated factories instance possibilities
        /// </summary>
        public enum FinanceDataImport { YAHOO, GOOGLE };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="importFrom">Enum of factory</param>
        /// <returns>Factory instance to create FinanceData object</returns>
        public static IFinanceDataService getWeatherDataService(FinanceDataImport importFrom)
        {
            switch (importFrom)
            {
                case FinanceDataImport.YAHOO:
                    return FinanceDataServiceYahooFactory.Instance;
                case FinanceDataImport.GOOGLE:
                    return FinanceDataServiceGoogleFactory.Instance;
                default:
                    throw new FinanceDataServiceException("Wrong arguments");
            }
        }

        /// <summary>
        /// Inherited classes should implement IFinanceDataService methods
        /// </summary>
        /// <param name="companySymbol">Symbol stock of company</param>
        /// <returns>Finance data from factory asked</returns>
        public abstract FinanceData getFinanceData(string companySymbol);

    }
}
