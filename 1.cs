// Rotate an array
// Rotate an integer array to the right by k positions, without using any built-in rotate helper. Print
// the array before and after.
// E X P E C T E D O U T P U T
// Before: 1 2 3 4 5 6 7
// k = 3
// After: 5 6 7 1 2 3 4
using System;

class Program{ 
    static void Main(){
        int[] arr={1,2,3,4,5,6,7};
        int k=3;
        Console.Write("Before: ");
        for (int i=0; i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }

        k=k%arr.Length;
        int[] result=new int[arr.Length];
        for (int i=0;i<arr.Length;i++){
            result[(i+k)%arr.Length]=arr[i];
        }
        Console.WriteLine();
        Console.WriteLine("k="+k);
        Console.Write("After: ");
        for (int i=0;i<result.Length;i++)
        {
            Console.Write(result[i]+" ");
        }
    }
}