using System;
class Program{
    static void CheckPerfectNumber(){
        int n=int.Parse(Console.ReadLine()),s=0;
        for(int i=1;i<n;i++){if(n%i==0)s+=i;}
        Console.WriteLine(s==n?"Perfect number":"Not Perfect");
    }
    static void Main(){CheckPerfectNumber();}
}