using System;
class Program{
    static void CalculatePower(){
        int b=int.Parse(Console.ReadLine());
        int e=int.Parse(Console.ReadLine());
        int r=1;
        for(int i=0;i<e;i++){r=r*b;}
        Console.WriteLine(r);
    }
    static void Main(){CalculatePower();}
}