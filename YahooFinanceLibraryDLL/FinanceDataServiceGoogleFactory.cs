using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FinanceLibrary
{
    class FinanceDataServiceGoogleFactory : FinanceDataServiceFactory
    {
        private static FinanceDataServiceGoogleFactory instance;
        private FinanceDataServiceGoogleFactory() { }
        public static FinanceDataServiceGoogleFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FinanceDataServiceGoogleFactory();
                }
                return instance;
            }
        }

        public override FinanceData getFinanceData(string companySymbol)
        {
            string companyName, changeInPercent, lastTradeTime, lastTradeDate;
            float lastTradePrice, change, previousClose;

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
                    companyName = xn["Name"].InnerText + " from google factory";
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
