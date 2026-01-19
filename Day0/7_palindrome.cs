using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string cleaned = input.Replace(" ", "").ToLower();
        string reversed = "";
        for (int i = cleaned.Length - 1; i >= 0; i--)
        {
            reversed += cleaned[i];
        }
        if (cleaned == reversed)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a palindrome");
    }
}
