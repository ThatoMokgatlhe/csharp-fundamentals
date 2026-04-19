using System;

public interface IPrinter { void Print(string text); }
public class ConsolePrinter : IPrinter {
    public void Print(string text) => Console.WriteLine(text);
}

class Program {
    static void Main() {
        new ConsolePrinter().Print("Hello Interfaces");
    }
}
