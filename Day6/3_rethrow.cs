using System;

public class Worker {
    public void Do() {
        try {
            throw new Exception("Inner failure");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}

class Program {
    static void Main() {
        try {
            new Worker().Do();
        } catch {
            Console.WriteLine("Rethrown to caller");
        }
    }
}
