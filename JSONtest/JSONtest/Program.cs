using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONtest {
    class Program {
        static void Main(string[] args) {

            string json = File.ReadAllText(@"D:\Temp\ETHtest2.txt");
            var json1 = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json); // This can be made recursive?

            //Console.WriteLine(json);

            string json2 = json1["data"]["quote"].ToString();
            //Console.WriteLine(json2.GetType());
            //Console.WriteLine(json2);

            Dictionary<string, Dictionary<string, object>> json3 = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json2);
            double json4 = (double)json3["ETH"]["price"];
            Console.WriteLine(json4);

            Console.ReadKey();
        }

        public static Dictionary<string, Dictionary<string, object>> ParseJson(string json) {
            return JsonConvert.DeserializeObject <Dictionary<string, Dictionary<string, object>>>(json);
        }
    }
}
