using System;
new Log().L(Console.ReadLine());
abstract class B { public abstract void L(string m); }
class Log : B { public override void L(string m) => Console.Write(m); }
