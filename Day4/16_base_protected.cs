using System;
Console.Write(new D(Console.ReadLine()).T);
class B(string t) { public string T { get; } = $"Report Title: {t}"; }
class D(string t) : B(t);
