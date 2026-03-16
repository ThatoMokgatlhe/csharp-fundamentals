using System;
var i = Console.ReadLine().Split();
Console.Write(i.Length > 1 ? new Point(int.Parse(i[0]), int.Parse(i[1])) : new Point());
record Point(int X = 0, int Y = 0) { public override string ToString() => $"X={X}, Y={Y}"; }
