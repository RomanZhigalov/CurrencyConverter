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
        public float Value { get; set; }
        public float Previous { get; set; }

        public Currency(string charcode, string name, float value, int nominal)
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
