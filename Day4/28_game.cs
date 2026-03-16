using System;
if (Console.ReadLine() == "start") new C().R();
abstract class G { public void R() { S(); P(); } protected abstract void S(); protected abstract void P(); }
class C : G { protected override void S() => Console.WriteLine("Chess setup complete"); protected override void P() => Console.Write("Playing chess (default)"); }
