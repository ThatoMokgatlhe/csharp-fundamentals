using System;

class Program {
    static void ValidatePassword() {
        string password = Console.ReadLine();
        if (password.Length >= 8)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }

    static void Main() {
        ValidatePassword();
    }
}
