using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceLibrary;

namespace FinanceLibraryTest
{
    [TestClass]
    public class FinanceLibraryTest
    {
        /// <summary>
        /// Check that we got financeData with wanted value
        /// </summary>
        [TestMethod]
        public void GetFinanceDataFromYahoo()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("GOOG");
            Assert.IsInstanceOfType(yahooInstance, typeof(FinanceData));
        }

        /// <summary>
        /// Check we got exception when sending empty symbol
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void EmptySymbol()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("");
        }

        /// <summary>
        /// Check we got exception when we got to connection to server
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void NoConnection()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("GOOG");
        }

        /// <summary>
        /// Check we got exception when sending unknown symbol
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void WrongSymbol()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("SDFDFDPOI");
        }
    }
}
