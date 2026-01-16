using System;
class Program{
    static void CalculateArrayStats(){
        string[] a=Console.ReadLine().Split(' ');
        int s=0;for(int i=0;i<a.Length;i++){s+=int.Parse(a[i]);}
        Console.WriteLine("Sum:"+s);
        Console.WriteLine("Average:"+(s*1.0/a.Length).ToString("F2"));
    }
    static void Main(){CalculateArrayStats();}
}