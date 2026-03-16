using System;
Console.Write($"Environment: {new Config(Console.ReadLine()).E}");
record Config(string E);
