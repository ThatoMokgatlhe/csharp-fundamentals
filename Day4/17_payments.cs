using System;
for (int i=0; i<2; i++) {
    var l = Console.ReadLine().Split();
    ((IP)(l[0] == "credit" ? new C() : new P())).Pay(decimal.Parse(l[1]));
}
interface IP { void Pay(decimal a); }
class C : IP { public void Pay(decimal a) => Console.WriteLine($"CreditCard paid {a:F2}"); }
class P : IP { public void Pay(decimal a) => Console.WriteLine($"Paypal paid {a:F2}"); }
