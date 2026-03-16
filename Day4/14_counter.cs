using System;
var c = new C(int.Parse(Console.ReadLine()));
while(Console.ReadLine() == "increment") c.I();
Console.Write(c.G());
class C(int v) { public void I() => v++; public int G() => v; }
