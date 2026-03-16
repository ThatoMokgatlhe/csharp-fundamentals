using System;
if (Console.ReadLine() == "create Dog") Console.Write($"Sound: {new D().S}");
abstract class A { public abstract string S { get; } }
class D : A { public override string S => "Bark"; }
