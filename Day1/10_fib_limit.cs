using System;
class Program{
    static void PrintFibonacciUpTo(){
        int n=int.Parse(Console.ReadLine());
        int a=0,b=1;
        Console.Write(a+" "+b+" ");
        while(true){
            int c=a+b;
            if(c>n)break;
            Console.Write(c+" ");
            a=b;b=c;
        }
    }
    static void Main(){PrintFibonacciUpTo();}
}