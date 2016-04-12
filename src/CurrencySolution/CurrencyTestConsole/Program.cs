using CurrencyApplication;
using CurrencyApplication.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {

            ICurrencyExchangeService listing = new ForexExchange();

            var gagga = listing.LookupRatesAsync("USD", "EUR", "NOK");

            foreach (var cc in gagga.Result)
                Console.WriteLine(cc.SwiftName + ": " + cc.Sell);

            Console.ReadKey();
        }
    }
}
