using System;
if (Console.ReadLine() == "describe") Console.Write(new D().D());
class B { public virtual string D() => "Base"; }
class D : B { public override string D() => base.D() + "; Derived appended info"; }
