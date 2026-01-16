using System;
class Program{
    static void PrintNestedPattern(){
        int n=int.Parse(Console.ReadLine());
        for(int i=1;i<=n;i++){for(int j=0;j<n;j++){Console.Write(i);}Console.WriteLine();}
    }
    static void Main(){PrintNestedPattern();}
}
