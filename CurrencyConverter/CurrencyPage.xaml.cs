using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CurrencyPage : Page
    {
        public CurrencyPage()
        {
            this.InitializeComponent();
            CurrencyList.ItemsSource = Rate.Сurrencies.Values.ToList();            
        }

        private void CurrencyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Currency selected = (Currency)CurrencyList.SelectedItem;
            
            if (Application.Current.Resources["curLeft"] == null)
            {
                Application.Current.Resources["curLeft"] = selected;
            }
            if (Application.Current.Resources["curRight"] == null)
            {
                Application.Current.Resources["curRight"] = selected;
            }
            Frame.Navigate(typeof(MainPage));
        }
    }
}
