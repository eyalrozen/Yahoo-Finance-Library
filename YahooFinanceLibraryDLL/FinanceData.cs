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
        float open { get; set; }
        float previousClose { get; set; }
        string changeInPercent { get; set; }
        float priceSales { get; set; }
        float priceBook { get; set; }
        Ratio ratio;
        Eps eps;
        TradeTime tradeTime;
        float oneYearTargetPrice { get; set; }
        long volume { get; set; }
        string yearRange { get; set; }
        string stockExchange { get; set; }
        string percentChange { get; set; }
        float ask { get; set; }
        long averageDailyVolume { get; set; }
        float bid { get; set; }
        float bookValue { get; set; }
        float change { get; set; }
        string currency { get; set; }
        float earningsShare { get; set; }
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
