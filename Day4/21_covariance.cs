using System; using System.Collections.Generic;
IEnumerable<object> s = new List<string> { "example string" };
foreach (var x in s) Console.Write($"Produced: {x}");
