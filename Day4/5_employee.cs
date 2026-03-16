using System;
Console.Write($"Role: {new Employee(Console.ReadLine()).Get()}");
class Base { protected string r; }
class Employee(string s) : Base { public string Get() => r = s; }
