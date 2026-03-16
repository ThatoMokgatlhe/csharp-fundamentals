using System;
try { Console.Write($"Age set to {new P(int.Parse(Console.ReadLine())).Age}"); }
catch (Exception) { }
class P(int a) { public int Age { get; } = a < 0 ? throw new Exception() : a; }
