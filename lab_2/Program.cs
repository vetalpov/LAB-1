using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SearchDuplicatesInDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Dictionary<string, int>
            {
                {"key1", 1},
                {"key2", 3},
                {"key3", 2}
            };

            var y = new Dictionary<string, int>
            {
                {"key1", 1},
                {"key2", 2}
            };

            var duplicates = new Dictionary<string, int>();
            foreach (var key in x.Keys)
            {
                if (y.ContainsKey(key) && x[key] == y[key])
                {
                    duplicates.Add(key, x[key]);
                }
            }

            string json = JsonSerializer.Serialize(duplicates);
            Console.WriteLine(json);
        }
    }
}
