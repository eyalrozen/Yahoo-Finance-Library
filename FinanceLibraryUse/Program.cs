using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceLibrary;

namespace FinanceLibraryUse
{
    class Program
    {
        static void Main(string[] args)
        {
            IFinanceDataService some = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.YAHOO);
            FinanceData yahooInstance = some.getFinanceData("GOOG");
            Console.WriteLine(yahooInstance.ToString());
            IFinanceDataService some2 = FinanceDataServiceFactory.getWeatherDataService(FinanceDataServiceFactory.FinanceDataImport.GOOGLE);
            FinanceData googleInstance = some2.getFinanceData("INTC");
            Console.WriteLine(googleInstance.ToString());
        }
    }
}
