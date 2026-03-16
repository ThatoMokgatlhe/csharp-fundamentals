using System;
Console.ReadLine(); Console.ReadLine();
new P().P(new D("Doc1")); new P().P(new I("Img1"));
interface IP { void P(); }
record D(string n) : IP { public void P() => Console.WriteLine($"Printing document: {n}"); }
record I(string n) : IP { public void P() => Console.Write($"Printing image: {n}"); }
class P { public void P(IP p) => p.P(); }
