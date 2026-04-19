using System;

public interface IA { void Do(); }
public interface IB { void Do(); }

public class Dual : IA, IB {
    void IA.Do() => Console.WriteLine("IA.Do called");
    void IB.Do() => Console.WriteLine("IB.Do called");
}

class Program {
    static void Main() {
        Dual d = new Dual();
        ((IA)d).Do();
        ((IB)d).Do();
    }
}
