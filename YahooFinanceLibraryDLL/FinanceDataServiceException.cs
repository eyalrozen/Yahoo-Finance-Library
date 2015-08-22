using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceLibraryDLL
{
    class FinanceDataServiceException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public FinanceDataServiceException()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public FinanceDataServiceException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public FinanceDataServiceException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
