using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrencyApplication.Models
{
    [XmlRoot("row")]
    public class ExchangeRate
    {
        [XmlElement("base_swift")]
        public string SwiftBaseCode { get; set; }

        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }

        [XmlElement("swift_name")]
        public string SwiftName { get; set; }

        [XmlElement("buy_cash")]
        public string Buy { get; set; }

        [XmlElement("sell_cash")]
        public string Sell { get; set; }

    }
}
