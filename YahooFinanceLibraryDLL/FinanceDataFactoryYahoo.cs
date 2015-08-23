using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace YahooFinanceLibraryDLL
{
    class FinanceDataFactoryYahoo : IFinanceDataService
    {
        /// <summary>
        /// 
        /// </summary>
        private static FinanceDataFactoryYahoo instance;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        private FinanceDataFactoryYahoo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {
            //FinanceData financeData = new FinanceData();
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
                throw new FinanceDataServiceException("Unable to connect to http Yahoo server. Reason: " + e.Message);
                return null;
            }

            try
            {
                XmlNodeList xnList = xml.SelectNodes("/query/results/quote");
                foreach (XmlNode xn in xnList)
                {
                    string companyName = xn["Name"].InnerText;
                    double lastTradePrice = double.Parse(xn["LastTradePriceOnly"].InnerText);
                    double change = double.Parse(xn["Change"].InnerText);
                    string changeinPercent = xn["ChangeinPercent"].InnerText;
                    string lastTradeTime = xn["LastTradeTime"].InnerText;
                    string lastTradeDate = xn["LastTradeDate"].InnerText;

                    return new FinanceData(companySymbol, companyName, lastTradePrice, change, changeinPercent, lastTradeTime, lastTradeDate);
                }
            }
            catch (Exception e)
            {
                throw new FinanceDataServiceException("Unable to parse node list. Reason: " + e.Message);
            }

            return new FinanceData();
        }
    }
}
