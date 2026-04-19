using System;

public interface IAnimal { void Speak(); }
public interface IMammal : IAnimal { void Nurse(); }

public class Dog : IMammal {
    public void Speak() => Console.WriteLine("Woof");
    public void Nurse() => Console.WriteLine("Nursing");
}

class Program {
    static void Main() {
        var d = new Dog();
        d.Speak();
        d.Nurse();
    }
}
