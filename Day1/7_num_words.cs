using System;
class Program{
    static void NumberToWords(){
        int d=int.Parse(Console.ReadLine());
        string[] w={"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
        Console.WriteLine(w[d]);
    }
    static void Main(){NumberToWords();}
}