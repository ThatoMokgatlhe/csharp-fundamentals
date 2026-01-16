using System;
class Program{
    static void SwapNumbers(){
        int a=int.Parse(Console.ReadLine()),b=int.Parse(Console.ReadLine());
        Console.WriteLine("Before: a="+a+", b="+b);
        int t=a;a=b;b=t;
        Console.WriteLine("After: a="+a+", b="+b);
    }
    static void Main(){SwapNumbers();}
}