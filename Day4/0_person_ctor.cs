using System;
var i = Console.ReadLine().Split();
Console.Write(new Person(i[0], int.Parse(i[1])));
record Person(string Name, int Age) { public override string ToString() => $"Name: {Name}, Age: {Age}"; }
