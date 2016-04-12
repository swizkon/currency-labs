using CurrencyApplication;
using CurrencyApplication.Impl;
using CurrencyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CurrencyMvcApplication.Controllers
{
    public class ExchangeRatesController : ApiController
    {
        // GET api/values
        public  IEnumerable<ExchangeRate> Get(string swiftCodes)
        {
            ICurrencyExchangeService listing = new ForexExchange();

            var result = listing.LookupRates(swiftCodes.Split(','));

            return new List<ExchangeRate>(result);
        }

        /*
        // GET api/values
        public ExchangeRate GetNice()
        {
            return new ExchangeRate();
        }

        // GET api/values
        [HttpGet]
        public ExchangeRate Sample(string swiftCodes)
        {
            return new ExchangeRate();
        }
        */

    }
}