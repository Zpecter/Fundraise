﻿using System;
using System.Collections.Generic;
using System.Text;
using Fundraise.Core.Entities;

namespace Fundraise.Core.Services
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private FundraiseContext _context;

        public CurrencyRepository(FundraiseContext context)
        {
            _context = context;
        }

        public Currency Create(string code, string symbol, string name)
        {
            var currency = new Currency(code, symbol, name);
            _context.Currencies.Add(currency);
            _context.SaveChanges();
            return currency;
        }

        public Currency FindByCode(string currencyCode)
        {
            return _context.Currencies.Find(currencyCode);
        }
    }
}
