using System;
if (Console.ReadLine() == "duck") { var d = new D(); d.F(); d.S(); }
interface IF { void F(); } interface IS { void S(); }
class D : IF, IS { public void F() => Console.WriteLine("Duck flies"); public void S() => Console.Write("Duck swims"); }
