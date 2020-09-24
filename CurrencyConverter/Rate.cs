using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Windows.Storage.Streams;
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace CurrencyConverter
{
    class Rate
    {
        //Переменная для хранения ссылки на файл с курсами валют
        private Uri request = new Uri("https://www.cbr-xml-daily.ru/daily_json.js");
        //Словарь для хранения объектов класса Currency которые содержать информацию о курсах валют
        public Dictionary<string, Currency> Сurrencies { get; set; }

        public Rate()
        {
            SetRate();
        }
        private async void SetRate()
        {
            //Создаем запрос
            HttpClient httpClient = new HttpClient();

            //Получаем ответ и записываем его в строку
            HttpResponseMessage httpResponse = (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
            string response = await httpResponse.Content.ReadAsStringAsync();

            //Создаем словарь в который записываем результаты десериализации
            Dictionary<string, JToken> results = new Dictionary<string, JToken>();
            results = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(response);

            //Конвертируем информацию а курсах валют в словарь 
            Сurrencies = results["Valute"].ToObject<Dictionary<string, Currency>>();
            //Добавляем Российский рубль
            Сurrencies.Add("RUB", new Currency("RUB", "Российский рубль", 1, 1));
        }
    }
}
