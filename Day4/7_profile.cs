using System;
var i = Console.ReadLine().Split(); var p = new Prof(i[0], i[1]);
Console.Write($"Username: {p.U}\nEmail: {p.Get()}");
record Prof(string U, string E) { public string Get() => E; }
