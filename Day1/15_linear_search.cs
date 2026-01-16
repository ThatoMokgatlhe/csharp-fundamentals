using System;
class Program{
    static void LinearSearch(){
        string[] a=Console.ReadLine().Split(' ');
        int[] arr=new int[a.Length];
        for(int i=0;i<a.Length;i++){arr[i]=int.Parse(a[i]);}
        int target=int.Parse(Console.ReadLine());
        int idx=-1;
        for(int i=0;i<arr.Length;i++){if(arr[i]==target){idx=i;break;}}
        Console.WriteLine(idx);
    }
    static void Main(){LinearSearch();}
}