using System;
class Program{
    static void FindLCM(){
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int g=a,h=b;
        while(h!=0){int t=h;h=g%h;g=t;}
        Console.WriteLine((a*b)/g);
    }
    static void Main(){FindLCM();}
}