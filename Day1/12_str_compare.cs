using System;
class Program{
    static void CompareStrings(){
        string a=Console.ReadLine();
        string b=Console.ReadLine();
        if(a.ToLower()==b.ToLower())Console.WriteLine("Strings are equal");
        else Console.WriteLine("Not equal");
    }
    static void Main(){CompareStrings();}
}