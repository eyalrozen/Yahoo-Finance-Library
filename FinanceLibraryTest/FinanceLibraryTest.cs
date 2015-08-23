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
            object intelFinance = new FinanceDataFactory().GetFinanceDataService(FinanceDataFactory.FinanceImport.YAHOO, "INTC");
            Assert.IsInstanceOfType(intelFinance, typeof(IFinanceDataService));
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void EmptySymbol()
        {
            object intelFinance = new FinanceDataFactory().GetFinanceDataService(FinanceDataFactory.FinanceImport.YAHOO, "");
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void NoConnection()
        {
            object intelFinance = new FinanceDataFactory().GetFinanceDataService(FinanceDataFactory.FinanceImport.YAHOO, "INTC");
        }

        [TestMethod]
        [ExpectedException(typeof(FinanceDataServiceException))]
        public void WrongSymbol()
        {
            object intelFinance = new FinanceDataFactory().GetFinanceDataService(FinanceDataFactory.FinanceImport.YAHOO, "STAMMASHU");
        }
    }
}
