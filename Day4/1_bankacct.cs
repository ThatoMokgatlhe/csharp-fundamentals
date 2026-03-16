using System;
var b = new BankAccount(decimal.Parse(Console.ReadLine()));
Console.Write($"Balance: {b.GetBalance()}");
class BankAccount(decimal b) { public decimal GetBalance() => b; }
