using System;
class Program{
    static void CalculateSimpleInterest(){
        double p=double.Parse(Console.ReadLine());
        double r=double.Parse(Console.ReadLine());
        double t=double.Parse(Console.ReadLine());
        Console.WriteLine((p*r*t/100).ToString("F2"));
    }
    static void Main(){CalculateSimpleInterest();}
}