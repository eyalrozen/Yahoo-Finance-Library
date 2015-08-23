using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Create FinanceData instance via indicated server (FinanceImport enum)
    /// </summary>
    public class FinanceDataFactory
    {
        /// <summary>
        /// Create enum for each possible finance import option
        /// </summary>
        public enum FinanceImport { YAHOO };

        /// <summary>
        /// Factory of FinanceData object, will import data via FinanceImport enum value
        /// Throws FinanceDataServiceException
        /// </summary>
        /// <param name="importFrom">Enum of wanted server import</param>
        /// <param name="companySymbol">Stock company symbol</param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(FinanceImport importFrom, string companySymbol)
        {
            if (companySymbol == "") throw new FinanceDataServiceException("Symbol cannot be empty string");

            try
            {
                switch (importFrom)
                {
                    case FinanceImport.YAHOO:
                        return FinanceDataFactoryYahoo.Instance.GetFinanceDataService(companySymbol);
                    default:
                        throw new FinanceDataServiceException("FinanceImport enum is invalid");
                }
            }
            catch (Exception e)
            {
                throw new FinanceDataServiceException("Unable to create FinanceData object with symbol [" + companySymbol + "]"
                + " from " + importFrom.ToString() + ". Reason: " + e.Message, e);
            }
        }
    }
}
