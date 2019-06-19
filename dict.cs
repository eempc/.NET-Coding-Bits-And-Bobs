            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in dict) {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            if (dict.TryGetValue("Key 0", out int x)) {

            }

            if (dict.ContainsKey("Key 0")) {

            }
