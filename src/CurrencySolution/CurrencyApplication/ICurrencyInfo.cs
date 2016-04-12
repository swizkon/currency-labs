﻿using CurrencyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApplication
{
    public interface ICurrencyInfo
    {
        Task<IEnumerable<ExchangeRate>> LookupRates(params string[] swiftCodes);
    }
}
