using System;
class Program{
    static void CheckArmstrong(){
        int n=int.Parse(Console.ReadLine()),x=n,s=0;
        while(x>0){int d=x%10;s+=d*d*d;x/=10;}
        Console.WriteLine(s==n?"Armstrong number":"Not Armstrong");
    }
    static void Main(){CheckArmstrong();}
}