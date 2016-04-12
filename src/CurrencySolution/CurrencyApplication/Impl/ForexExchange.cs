using CurrencyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CurrencyApplication.Impl
{
    public class ForexExchange : ICurrencyInfo
    {
        private const string ratesUrl = "https://www.forex.se/ratesxml.asp?id=492";

        private List<ExchangeRate> currentRates = null;

        public async Task<IEnumerable<ExchangeRate>> LookupRates(string[] swiftCodes)
        {
            List<string> swiftFilter = new List<string>(swiftCodes);

            // Check if we need to reach out to the server...
            if (currentRates == null)
            {
                using (HttpClient browser = new HttpClient())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(CurrencyIndex));
                    var rateStream = await browser.GetStreamAsync(ratesUrl);

                    var currencyIndex = (CurrencyIndex)serializer.Deserialize(rateStream);
                    currentRates = currencyIndex.Rates;
                }
            }

            // Filter out the requested rates
            return currentRates.Where(curr => swiftFilter.Contains(curr.SwiftCode));
        }

    }
}
