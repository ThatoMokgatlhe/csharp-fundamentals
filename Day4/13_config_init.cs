using System;
var i = Console.ReadLine().Split(' ', '=');
var a = new A { N = i[1], V = i[3] };
Console.Write($"{a.N} v{a.V}");
class A { public string N { get; init; } public string V { get; init; } }
