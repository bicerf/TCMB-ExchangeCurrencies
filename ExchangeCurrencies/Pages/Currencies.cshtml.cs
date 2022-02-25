using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeCurrencies.Data;
using ExchangeCurrencies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExchangeCurrencies.Pages
{
    public class CurrenciesModel : PageModel
    {
        private IExchange _exchange { get; }
        public List<Dovizkurlari> CurrenciesList { get; set; }
        public List<Dovizkurlari2> CurrenciesChangeList { get; set; }
        public CurrenciesModel(IExchange exchange)
        {
            _exchange = exchange;
        }
        public async  Task<IActionResult> OnGetAsync()
        {
            var currencies = await _exchange.GetCurrencies();
            CurrenciesList = currencies.ToList();
            var currenciesChange = await _exchange.GetCurrenciesChange();
            CurrenciesChangeList = currenciesChange.ToList();

            return Page();
        }
    }
}
