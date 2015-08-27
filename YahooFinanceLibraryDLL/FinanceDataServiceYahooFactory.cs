using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FinanceLibrary
{
    class FinanceDataServiceYahooFactory : FinanceDataServiceFactory
    {
        #region Singleton
        private static FinanceDataServiceYahooFactory instance;
        private FinanceDataServiceYahooFactory() { }
        public static FinanceDataServiceYahooFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FinanceDataServiceYahooFactory();
                }
                return instance;
            }
        }
        #endregion

        /// <summary>
        /// Implement getFinanceData methods from interface
        /// </summary>
        /// <param name="companySymbol">Company symbol of wanted finance data</param>
        /// <returns>FinanceData or throw FinanceDataServiceExcetpion</returns>
        public override FinanceData getFinanceData(string companySymbol)
        {
            string companyName, changeInPercent, lastTradeTime, lastTradeDate;
            float lastTradePrice, change, previousClose;

            if (companySymbol == "")
            {
                throw new FinanceDataServiceException("Cannot handle empty company symbol to import finance data");
            }

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
                    lastTradePrice = float.Parse(xn["LastTradePriceOnly"].InnerText);
                    change = float.Parse(xn["Change"].InnerText);
                    changeInPercent = xn["ChangeinPercent"].InnerText;
                    previousClose = float.Parse(xn["PreviousClose"].InnerText);
                    lastTradeTime = xn["LastTradeTime"].InnerText;
                    lastTradeDate = xn["LastTradeDate"].InnerText;

                    return new FinanceData(companyName, companySymbol, previousClose, change, changeInPercent, lastTradeDate, lastTradeTime);
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
