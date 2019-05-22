using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace CMCTest {
    class Program {
        private static string API_KEY = "2977f70f-3ac7-4a5e-833c-7ea88278f25c";
        private static string url0 = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest";
        private static string url1 = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/info?id=1,2,10";
        private static string url2 = "https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest";
        private static string url3 = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest?symbol=BTC,ETH,LTC&convert=BTC,ETH,EUR";
        private static string url4 = "https://pro-api.coinmarketcap.com/v1/tools/price-conversion?symbol=BTC&amount=50&convert=USD,GBP,LTC";
        private static string url5 = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/quotes/latest";
        private static string url6 = "https://pro-api.coinmarketcap.com/v1/tools/price-conversion";

        static void Main(string[] args) {
            try {
                string json = makeAPICall("USD", "100", "ETH");
                //Console.WriteLine(json);

                //Console.WriteLine(json);
                //using (StreamWriter writer = new StreamWriter(@"D:\Temp\ETHtest2.txt")) {
                //    writer.Write(json);
                //}
                //dynamic obj = JsonConvert.DeserializeObject("{\"data\"   }");

                //dynamic data = JsonConvert.DeserializeObject<PriceObject>(json);

                ////foreach (var item in data.DataItems) {
                ////    //var x = item.Value.quote.Values.
                ////    Console.WriteLine(item.Key);
                ////    //var x = item.Key;
                ////    Console.WriteLine(item.Value.quote.quoteUSD["price"].ToString());
                ////}

                //foreach (var item in data.DataItems) {
                //    Console.WriteLine(item.Key);
                //}
                    
                Console.WriteLine(json.ToString());


            } catch (WebException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static string makeAPICall(string currency, string amount, string cryptocurrency) {
            var URL = new UriBuilder(url6);

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["amount"] = amount;
            queryString["convert"] = cryptocurrency;

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            
            return client.DownloadString(URL.ToString());
        }
    }

    //public class PriceObject {
    //    [JsonProperty(PropertyName = "USD")]
    //    public Dictionary<string, USDDataItem> USDDataItems  {get; set;}
    //}  

    //public class USDDataItem {
    //    public double price { get; set; }
    //    public double volume_24h { get; set; }
    //    public double percent_change_1h { get; set; }
    //    public double percent_change_24h { get; set; }
    //    public double percent_change_72h { get; set; }
    //    public double market_cap { get; set; }
    //    public string last_updated { get; set; }
    //}

    public class PriceObject {
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, DataItem> DataItems { get; set; }
    }

    public class DataItem {

        //public Int32 id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public string last_updated { get; set; }
        //public string quote { get; set; } // Careful about null here

        
        public Dictionary<string, Quote> quote { get; set; }

    }

    public class Quote {
        
        public Dictionary<string, Crypto> cry { get; set; }
    }

    public class Crypto {
        public double price { get; set; }
        public string last_updated { get; set; }
    }

}
