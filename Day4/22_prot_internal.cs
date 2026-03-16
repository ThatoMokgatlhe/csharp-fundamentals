using System;
if (Console.ReadLine() == "call") new F().C();
public class B { protected internal void S() => Console.Write("Hello from Friend"); }
class F : B { public void C() => S(); }
