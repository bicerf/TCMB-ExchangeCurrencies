using System;
using System.Collections.Generic;

#nullable disable

namespace ExchangeCurrencies.Models
{
    public partial class Dovizkurlari2
    {
        public DateTime Date { get; set; }
        public string Unit { get; set; }
        public string Isim { get; set; }
        public string CurrencyName { get; set; }
        public double? ForexBuying { get; set; }
        public double? ForexSelling { get; set; }
        public double? BanknoteBuying { get; set; }
        public double? BanknoteSelling { get; set; }
    }
}
