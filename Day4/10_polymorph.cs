using System; using System.Collections.Generic;
var s = new List<S> { new C(2), new R(2, 5) };
foreach (var h in s) Console.WriteLine(h is C ? $"{h.A():F4}" : $"{h.A()}");
abstract record S { public abstract double A(); }
record C(double R) : S { public override double A() => Math.PI * R * R; }
record R(double W, double H) : S { public override double A() => W * H; }
