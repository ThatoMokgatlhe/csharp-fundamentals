using System;
class Program{
    static void SumEvenNumbers(){
        string[] a=Console.ReadLine().Split(' ');
        int sum=0;
        for(int i=0;i<a.Length;i++){
            int x=int.Parse(a[i]);
            if(x%2==0)sum+=x;
        }
        Console.WriteLine(sum);
    }
    static void Main(){SumEvenNumbers();}
}