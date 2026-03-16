using System;
var d = new D(); ((IA)d).Do(); ((IB)d).Do();
interface IA { void Do(); } interface IB { void Do(); }
class D : IA, IB { void IA.Do() => Console.WriteLine("(IA)dual -> IA.Do() output"); void IB.Do() => Console.Write("(IB)dual -> IB.Do() output"); }
