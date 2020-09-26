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
using System.Threading.Tasks;
using System.Net;
using Windows.Storage.Streams;
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Threading;
using Windows.ApplicationModel.Activation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoadPage : Page
    {
        internal Frame rootFrame;

        public LoadPage()
        {
            this.InitializeComponent();
            Rate.LoadRateToDictionary();
            rootFrame = new Frame();
            this.Loaded += LoadPage_Loaded;
        }

        private void LoadPage_Loaded(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(MainPage));
            Window.Current.Content = rootFrame;
        }
    }
}
