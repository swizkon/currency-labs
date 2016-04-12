using CurrencyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApplication
{
    public interface ICurrencyExchangeService
    {
        Task<IEnumerable<ExchangeRate>> LookupRatesAsync(params string[] swiftCodes);

        IEnumerable<ExchangeRate> LookupRates(params string[] swiftCodes);
    }
}
