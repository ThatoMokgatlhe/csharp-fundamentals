using System;
var t = Console.ReadLine(); Console.Write(t == "car" ? new C().D() : new T().D());
class V { public virtual string D() => ""; }
class C : V { public override string D() => "Car: I am a car"; }
class T : V { public override string D() => "Truck: I am a truck"; }
