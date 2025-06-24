Dictionary<string, int> dict =  new Dictionary<string, int>();

dict["a"] = 1;
dict["b"] = 2;

Console.WriteLine(dict["a"]);

foreach (var kv in dict)
{
    Console.WriteLine($"{kv.Key}: {kv.Value}");
}
