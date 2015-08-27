using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    /// <summary>
    /// Finance Data object were data will be saved
    /// </summary>
    public class FinanceData
    {
        #region Members
        Company company { get; set; }
        public float open { get; private set; }
        public float previousClose { get; private set; }
        public string changeInPercent { get; private set; }
        public float priceSales { get; private set; }
        public float priceBook { get; private set; }
        Ratio ratio { get; set; }
        Eps eps { get; set; }
        TradeTime tradeTime { get; set; }
        public float oneYearTargetPrice { get; private set; }
        public long volume { get; private set; }
        public string yearRange { get; private set; }
        public string stockExchange { get; private set; }
        public string percentChange { get; private set; }
        public float ask { get; private set; }
        public long averageDailyVolume { get; private set; }
        public float bid { get; private set; }
        public float bookValue { get; private set; }
        public float change { get; private set; }
        public string currency { get; private set; }
        public float earningsShare { get; private set; }
        #endregion

        internal FinanceData(string companyName, string companySymbol, float previousClose, float change, string changeInPercent, string lastDate,
            string lastTime, float open = 0, float priceSales = 0, float priceBook = 0, float peRatio = 0, float pegRatio = 0, float shortRatio = 0, float estimateCurrentYearPrice = 0,
             float estimateNextYearPrice = 0, float oneYearTargetPrice = 0, long volume = 0,
             string yearRange = "", string stockExchange = "", string percentChange = "", float ask = 0, long averageDailyVolume = 0, float bid = 0,
             float bookValue = 0, string currency = "", float earningsShare = 0)
        {
            this.company = new Company(companyName, companySymbol);
            this.open = open;
            this.previousClose = previousClose;
            this.changeInPercent = changeInPercent;
            this.priceSales = priceSales;
            this.priceBook = priceBook;
            this.ratio = new Ratio(peRatio, pegRatio, shortRatio);
            this.eps = new Eps(estimateCurrentYearPrice, estimateNextYearPrice);
            this.tradeTime = new TradeTime(lastDate, lastTime);
            this.oneYearTargetPrice = oneYearTargetPrice;
            this.volume = volume;
            this.yearRange = yearRange;
            this.stockExchange = stockExchange;
            this.percentChange = percentChange;
            this.ask = ask;
            this.averageDailyVolume = averageDailyVolume;
            this.bid = bid;
            this.bookValue = bookValue;
            this.change = change;
            this.currency = currency;
            this.earningsShare = earningsShare;
        }

        /// <summary>
        /// To string override to print easily the instance
        /// </summary>
        /// <returns>string with description</returns>
        public override string ToString()
        {
            return "Company: " + company.ToString() + "\nTrade date: " + tradeTime.ToString() + "\nChange: " + change + "\n"
                + "Previous close: " + previousClose;
        }

    }
}
