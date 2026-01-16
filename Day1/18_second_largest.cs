using System;
class Program{
    static void FindSecondLargest(){
        string[] a=Console.ReadLine().Split(' ');
        int[] arr=new int[a.Length];
        for(int i=0;i<a.Length;i++){arr[i]=int.Parse(a[i]);}
        int max=-999999,sec=-999999;
        for(int i=0;i<arr.Length;i++){
            if(arr[i]>max){sec=max;max=arr[i];}
            else if(arr[i]>sec && arr[i]!=max){sec=arr[i];}
        }
        Console.WriteLine(sec);
    }
    static void Main(){FindSecondLargest();}
}