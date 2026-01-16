using System;
class Program{
    static void FindGCD(){
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        while(b!=0){int t=b;b=a%b;a=t;}
        Console.WriteLine(a);
    }
    static void Main(){FindGCD();}
}