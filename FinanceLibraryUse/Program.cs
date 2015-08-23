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
            try
            {
                object intelFinance = new FinanceDataFactory().GetFinanceDataService(FinanceDataFactory.FinanceImport.YAHOO, "goog");
                Console.WriteLine(intelFinance.ToString());
            }
            catch (FinanceDataServiceException e)
            {
               Console.WriteLine(e.Message);
            }

        }
    }
}
