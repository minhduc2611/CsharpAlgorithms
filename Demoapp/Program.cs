using System;

class demo
{
    // Find the two repeating elements in a given array
    static void CheckIfHasRepeat(int[] arr){
        int i,j;
        Console.WriteLine("the repeated elements are : ");
        for(i = 0 ; i < arr.Length ; i++){
            for(j = i+1; j<arr.Length; j++){
                if(arr[j] == arr[i]){
                    Console.WriteLine(arr[i]+" ");      
                }
            }
        }


    }
    static void Main(string[] args)
    {
        int[] Arr = new int[] {1,2,3,1,2};

        CheckIfHasRepeat(Arr);
    }
}
