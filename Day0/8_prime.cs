using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not prime");
    }
}
