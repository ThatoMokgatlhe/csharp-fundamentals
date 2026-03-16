using System;
var i = Console.ReadLine().Split(); Console.Write(new P(i[0], int.Parse(i[1])).S());
interface I { string S(); }
record P(string N, int A) : I { public string S() => $"{{\"Name\":\"{N}\",\"Age\":{A}}}"; }
