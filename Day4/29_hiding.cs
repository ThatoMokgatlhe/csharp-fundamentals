using System;
var c = new C();
Console.WriteLine($"Parent.Name() -> {((P)c).N()}");
Console.WriteLine($"((Child)as Parent).Name() -> {((P)c).N()} (if called via Parent reference)");
Console.Write($"Child.Name() -> {c.N()}");
class P { public string N() => "Parent"; }
class C : P { public new string N() => "Child"; }
