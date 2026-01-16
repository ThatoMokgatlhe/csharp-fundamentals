using System;
class Program{
    static void ReverseNumber(){
        int n=int.Parse(Console.ReadLine());
        int r=0;
        while(n>0){r=r*10+n%10;n/=10;}
        Console.WriteLine(r);
    }
    static void Main(){ReverseNumber();}
}