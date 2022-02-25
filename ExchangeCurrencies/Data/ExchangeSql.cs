using ExchangeCurrencies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeCurrencies.Data
{
    public class ExchangeSql : IExchange
    {
        private ExchangeContext _exchangeContext { get; }
        public ExchangeSql(ExchangeContext exchangeContext)
        {
            _exchangeContext = exchangeContext;
        }
        public async Task<IEnumerable<Dovizkurlari>> GetCurrencies()
        {
            return await _exchangeContext.Dovizkurlaris.ToListAsync();
        }

        public async Task<IEnumerable<Dovizkurlari2>> GetCurrenciesChange()
        {
            return await _exchangeContext.Dovizkurlari2s.ToListAsync();
        }
    }
}
