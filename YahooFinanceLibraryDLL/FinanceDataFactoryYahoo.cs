using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FinanceLibrary
{
    /// <summary>
    /// Create FinanceData object from Yahoo server
    /// </summary>
    class FinanceDataFactoryYahoo : IFinanceDataService
    {
        /// <summary>
        /// Part of Singleton design pattern structure
        /// </summary>
        private static FinanceDataFactoryYahoo instance;

        /// <summary>
        /// Part of Singleton design pattern structure
        /// </summary>
        public static FinanceDataFactoryYahoo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FinanceDataFactoryYahoo();
                }
                return instance;
            }
        }

        /// <summary>
        /// Part of Singleton design pattern structure
        /// </summary>
        private FinanceDataFactoryYahoo()
        {
        }

        /// <summary>
        /// Implementation of IFinanceDataService
        /// Import finance data and parse xml received from yahoo server
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {
            string companyName, changeinPercent, lastTradeTime, lastTradeDate;
            double lastTradePrice, change;

            var addr =
                "https://query.yahooapis.com/v1/public/yql?q=select+%2A+from+yahoo.finance.quotes+where+symbol+in+%28%22" +
                companySymbol +
                "%22%29&format=xml&diagnostics=true&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(addr);
            }
            catch (Exception e)
            {
                throw new FinanceDataServiceException("Unable to connect to http Yahoo server. Reason: " + e.Message, e);
            }

            try
            {
                XmlNodeList xnList = xml.SelectNodes("/query/results/quote");
                foreach (XmlNode xn in xnList)
                {
                    companyName = xn["Name"].InnerText;
                    lastTradePrice = double.Parse(xn["LastTradePriceOnly"].InnerText);
                    change = double.Parse(xn["Change"].InnerText);
                    changeinPercent = xn["ChangeinPercent"].InnerText;
                    lastTradeTime = xn["LastTradeTime"].InnerText;
                    lastTradeDate = xn["LastTradeDate"].InnerText;

                    return new FinanceDataClass(companySymbol, companyName, lastTradePrice, change, changeinPercent, lastTradeTime, lastTradeDate);
                }
                throw new FinanceDataServiceException("The xml cannot be parsed");
            }
            catch (Exception e)
            {
                throw new FinanceDataServiceException("Unable to parse node list. Reason: " + e.Message, e);
            }
            
        }
    }
}
