using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Card
    {
        [DisplayName("Expiry month")]
        public string expiryMonth { get; set; }
        [DisplayName("Expiry year")]
        public string expiryYear { get; set; }
        [DisplayName("First 6 digits")]
        public string firstSixDigits { get; set; }
        [DisplayName("Last 4 digits")]
        public string lastFourDigits { get; set; }
        [DisplayName("Name")]
        public string holderName { get; set; }
    }

    public class Transactions
    {
        [DisplayName("Transaction type")]
        public string action { get; set; }
        [DisplayName("Amount")]
        public double amount { get; set; }
        [DisplayName("Brand ID")]
        public int brandId { get; set; }
        public Card card { get; set; }
        [DisplayName("Currency")]
        public string currencyCode { get; set; }
        [DisplayName("ID")]
        public string id { get; set; }
        [DisplayName("Tracking code")]
        public string trackingCode { get; set; }
    }
}
