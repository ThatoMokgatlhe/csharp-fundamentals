using System;
class Program{
    static void FindDuplicates(){
        string[] a=Console.ReadLine().Split(' ');
        int[] arr=new int[a.Length];
        for(int i=0;i<a.Length;i++){arr[i]=int.Parse(a[i]);}
        bool found=false;
        for(int i=0;i<arr.Length;i++){
            for(int j=i+1;j<arr.Length;j++){
                if(arr[i]==arr[j]){Console.Write(arr[i]+" ");found=true;}
            }
        }
        if(!found)Console.WriteLine("No duplicates");
    }
    static void Main(){FindDuplicates();}
}