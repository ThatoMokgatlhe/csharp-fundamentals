using System;
class Program{
    static void BubbleSort(){
        string[] a=Console.ReadLine().Split(' ');
        int[] arr=new int[a.Length];
        for(int i=0;i<a.Length;i++){arr[i]=int.Parse(a[i]);}
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr.Length-1;j++){
                if(arr[j]>arr[j+1]){
                    int t=arr[j];arr[j]=arr[j+1];arr[j+1]=t;
                }
            }
        }
        for(int i=0;i<arr.Length;i++){Console.Write(arr[i]);}
    }
    static void Main(){BubbleSort();}
}