using System;
class Program{
    static void PrintDigitFrequency(){
        string s=Console.ReadLine();
        int[] freq=new int[10];
        for(int i=0;i<s.Length;i++){freq[s[i]-'0']++;}
        for(int i=0;i<10;i++){if(freq[i]>0)Console.WriteLine(i+" appears "+freq[i]+" times");}
    }
    static void Main(){PrintDigitFrequency();}
}