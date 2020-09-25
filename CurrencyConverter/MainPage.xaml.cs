using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace CurrencyConverter
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        private void ResultTextBoxLeft_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            CheckDigit(sender);
        }
        private void ResultTextBoxRight_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            CheckDigit(sender);
        }

        private void ChangeButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["curLeft"] = null;
            Frame.Navigate(typeof(CurrencyPage));
        }
        private void ChangeButtonRight_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["curRight"] = null;
            Frame.Navigate(typeof(CurrencyPage));
        }

        private void CheckDigit(TextBox text)
        {
            if (!Regex.IsMatch(text.Text, "^\\d*\\.?\\d*$") && text.Text != "")
            {
                text.Text = "";
            }
        }
    }
}
