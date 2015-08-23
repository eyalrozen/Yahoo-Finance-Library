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
    public class FinanceDataFactory// : IFinanceDataService
    {
        /// <summary>
        /// 
        /// </summary>
        public enum FinanceImport { YAHOO };

 /*       /// <summary>
        /// 
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public abstract IFinanceDataService GetFinanceDataService(string companySymbol); */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="importFrom"></param>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(FinanceImport importFrom, string companySymbol)
        {
            switch (importFrom)
            {
                case FinanceImport.YAHOO:
                   // return new FinanceDataFactoryYahoo.Instance().GetFinanceDataService(companySymbol);
                    return FinanceDataFactoryYahoo.Instance.GetFinanceDataService(companySymbol);
                default:
                    return null;
            }
        }

        /*      /// <summary>
              /// 
              /// </summary>
              /// <param name="importFrom"></param>
              /// <param name="symbolCompany"></param>
              /// <returns></returns>
              public IFinanceDataService FinanceDataServiceFactory(FinanceImport importFrom, string symbolCompany)
              {
                  switch (importFrom)
                  {
                      case FinanceImport.YAHOO:
                          return FinanceDataFactoryYahoo.Instance.GetFinanceDataService(symbolCompany);
                      default:
                          return null;
                  }
              }
          }*/
    }
}
