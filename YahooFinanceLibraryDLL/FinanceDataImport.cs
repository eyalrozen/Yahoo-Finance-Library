using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace YahooFinanceLibraryDLL
{
    public class FinanceDataImport : IFinanceDataService
    {
        /// <summary>
        /// 
        /// </summary>
        private static FinanceDataImport instance;

        /// <summary>
        /// 
        /// </summary>
        public static FinanceDataImport Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FinanceDataImport();
                }
                return instance;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private FinanceDataImport()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companySymbol"></param>
        /// <returns></returns>
        public IFinanceDataService GetFinanceDataService(string companySymbol)
        {
            FinanceData financeData = new FinanceData();
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
                throw new FinanceDataServiceException("Unable to connect to http server. reason: " + e.Message);
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
                    Console.WriteLine("Company Name: " + companyName);
                    Console.WriteLine("last Trade Price: " + lastTradePrice);
                    Console.WriteLine("Change:" + change);
                    Console.WriteLine("Change in Percent:" + changeinPercent);
                    Console.WriteLine("Last trade date:" + lastTradeDate);
                    Console.WriteLine("Last Trade Time:" + lastTradeTime);

                    financeData.companyName = companyName;
                    financeData.lastTradeTime = lastTradeTime;
                    financeData.change = change;
                    financeData.currentValue = lastTradePrice;
                    financeData.percentChange = changeinPercent;
                    financeData.lastTradeDate = lastTradeDate;

                    return financeData;


                }
            }
            catch (Exception e)
            {
                throw new FinanceDataServiceException("Unable to find the node list. reason: " + e.Message);
            }

            return financeData;

        }
    }
}
