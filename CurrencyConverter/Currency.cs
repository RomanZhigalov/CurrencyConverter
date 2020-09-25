using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{

    public class Currency
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }

        public Currency(string charcode, string name, double value, int nominal)
        {
            CharCode = charcode;
            Name = name;
            Value = value;
            Nominal = nominal;
        }

        public Currency()
        {

        }
    }
}
