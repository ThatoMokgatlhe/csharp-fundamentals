using System;
Console.Write(new G().Greet(Console.ReadLine()));
sealed class G { public string Greet(string n) => $"Hello, {n}"; }
