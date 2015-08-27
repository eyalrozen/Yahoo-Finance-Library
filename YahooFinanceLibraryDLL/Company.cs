using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    class Company
    {
        string name { get; set; }
        string symbol { get; set; }

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
