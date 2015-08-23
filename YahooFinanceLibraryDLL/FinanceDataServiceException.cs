using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    public class FinanceDataServiceException : Exception
    {
        /// <summary>
        /// Initialize en new instance of the FinanceLibrary.FinanceDataServiceException() class
        /// </summary>
        public FinanceDataServiceException()
        {
        }

        /// <summary>
        /// Initialize en new instance of the FinanceLibrary.FinanceDataServiceException() 
        /// class with a specified error message
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public FinanceDataServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initialize en new instance of the FinanceLibrary.FinanceDataServiceException() 
        /// class with a specified error message and a reference to the inner exception that is
        /// the cause of this exception
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="inner">The exception that is the cause of the current exception, 
        /// or a null reference (Nothing in visual basic) if no inner exception is specified</param>
        public FinanceDataServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
