using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    class Company
    {
        public string name { get; private set; }
        public string symbol { get; private set; }

        public Company(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }

        public override string ToString()
        {
            return "Name: " + name + ", Symbol: " + symbol;
        }
    }
}
