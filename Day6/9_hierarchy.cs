using System;

public class AppException : Exception { }
public class SpecialAppException : AppException { }

class Program {
    static void Main() {
        try {
            throw new SpecialAppException();
        } catch (SpecialAppException) {
            Console.WriteLine("Caught SpecialAppException handler");
        } catch (AppException) {
            Console.WriteLine("Caught AppException handler");
        }
    }
}
