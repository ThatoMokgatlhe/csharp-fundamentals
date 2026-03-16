using System;
var i = Console.ReadLine().Split(); Console.WriteLine($"Circle area: {new Cir(double.Parse(i[1])).A():F4}");
i = Console.ReadLine().Split(); Console.Write($"Rectangle area: {new Rec(double.Parse(i[1]), double.Parse(i[2])).A()}");
abstract record Shape { public abstract double A(); }
record Cir(double R) : Shape { public override double A() => Math.PI * R * R; }
record Rec(double W, double H) : Shape { public override double A() => W * H; }
