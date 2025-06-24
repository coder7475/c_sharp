Dictionary<string, int> dict =  new Dictionary<string, int>();

dict["a"] = 1;
dict["b"] = 2;
dict.Add("c", 3);

Console.WriteLine(dict["a"]);

foreach (KeyValuePair<string, int> kv in dict)
    Console.WriteLine($"{kv.Key}: {kv.Value}");

dict.Remove("b");

foreach (KeyValuePair<string, int> kv in dict)
    Console.WriteLine($"{kv.Key}: {kv.Value}");


