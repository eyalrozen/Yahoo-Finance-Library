using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceLibraryDLL
{
    public class FinanceDataServiceFactory : IFinanceDataService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {

            var f = FinanceDataImport.Instance.GetFinanceDataService(companySymbol);
            return f;
        }


    }
}
