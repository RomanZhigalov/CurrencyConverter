using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Converter
    {
        public double ConvertTo(double val_1, double val_2)
        {
            return val_1 / val_2;
        }
        public double ConvertFrom(double val_1, double val_2)
        {
            return val_2 * val_1;
        }
    }
}
