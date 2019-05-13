using System;

class demo
{
    // sum of the elements of an given array of integers.

    public static int sumA(int[] arr){
        int len = arr.Length;
        int sumArr = 0;
        for(int i = 0 ; i <= len-1; i++){
            sumArr += arr[i];
        };
        return sumArr;
    }
    static void Main(string[] args)
    {
        int[] arr =  new int[]{1,2,3};
        Console.WriteLine(sumA(arr));
    }
}
