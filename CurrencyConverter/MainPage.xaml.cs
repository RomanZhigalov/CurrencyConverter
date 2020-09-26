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
using System.ServiceModel.Channels;

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
            Converting(sender, ResultTextBoxRight, sender);
        }
        private void ResultTextBoxRight_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            Converting(ResultTextBoxLeft, sender, sender);
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

        private void Converting(TextBox leftBox, TextBox rightBox, object sender)
        {
            Currency left = (Currency)Application.Current.Resources["curLeft"];
            Currency right = (Currency)Application.Current.Resources["curRight"];

            string pattern = "^\\d*\\.?\\d*$";

            double leftToRight = (right.Value / left.Value);
            double rightToLeft = (left.Value / right.Value);

            if(leftBox == sender && leftBox.Text != "" && Regex.IsMatch(leftBox.Text, pattern))
            {
                rightBox.Text = (Convert.ToDouble(leftBox.Text) * rightToLeft).ToString();
            }
            if (rightBox == sender && rightBox.Text != "" && Regex.IsMatch(rightBox.Text, pattern))
            {
                leftBox.Text = (Convert.ToDouble(rightBox.Text) * leftToRight).ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Currency temp = new Currency();
            temp = (Currency)Application.Current.Resources["curLeft"];
            Application.Current.Resources["curLeft"] = Application.Current.Resources["curRight"];
            Application.Current.Resources["curRight"] = temp;
            Frame.Navigate(typeof(MainPage));
        }
    }
}
