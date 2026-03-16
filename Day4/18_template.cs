using System;
new M().P(Console.ReadLine());
abstract class B { public void P(string i) => Console.Write(S(i)); protected abstract string S(string i); }
class M : B { protected override string S(string i) => $"Processed: {i}"; }
