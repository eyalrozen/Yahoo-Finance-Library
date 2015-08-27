using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceLibrary;

namespace FinanceLibraryTest
{
    [TestClass]
    public class FinanceLibraryTest
    {
        [TestMethod]
        public void GetFinanceDataFromYahoo()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("GOOG");
            Assert.IsInstanceOfType(yahooInstance, typeof(FinanceData));
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void EmptySymbol()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("");
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void NoConnection()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("GOOG");
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void WrongSymbol()
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("SDFDFDPOI");
        }
    }
}
