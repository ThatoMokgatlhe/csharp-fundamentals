using System;
var l = Console.ReadLine().Split(); Console.WriteLine(new M().A(int.Parse(l[1]), int.Parse(l[2])));
l = Console.ReadLine().Split(); Console.Write(new M().A(double.Parse(l[1]), double.Parse(l[2])).ToString("F1"));
class M { public int A(int a, int b) => a + b; public double A(double a, double b) => a + b; }
