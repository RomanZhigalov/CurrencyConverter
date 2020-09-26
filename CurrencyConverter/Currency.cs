using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CurrencyConverter
{

    public class Currency : INotifyPropertyChanged
    {
        private string charCode;
        private string name;
        public string ID { get; set; }
        public string NumCode { get; set; }

        public string CharCode
        {
            get { return charCode; }
            set
            {
                if (charCode != value)
                {
                    charCode = value;
                    OnPropertyChanged("CharCode");
                }
            }
        }
        public int Nominal { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}

