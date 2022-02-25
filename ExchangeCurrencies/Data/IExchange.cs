using ExchangeCurrencies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeCurrencies.Data
{
    public interface IExchange
    {
        Task<IEnumerable<Dovizkurlari>> GetCurrencies();
        Task<IEnumerable<Dovizkurlari2>> GetCurrenciesChange();

    }
}
