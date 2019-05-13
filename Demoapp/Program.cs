using System;

class demo
{
    // Checking if array is symmetric

    static Boolean CheckIfSymetric(int[] arr){
        for(int i = 0; i <arr.Length/2 ; i++ ){
            if(arr[i] != arr[(arr.Length-1)-i]){
                return false;
            }
        }
    return true;
        
    }
    static void Main(string[] args)
    {
        int[] arrSym = new int[]{1,2,3,2,1};
        int[] arrSym2 = new int[]{1,2,2,1};
        int[] arr = new int[]{1,2,3,4,2,1};
        //check 
        Console.WriteLine(CheckIfSymetric(arrSym)); 
        Console.WriteLine(CheckIfSymetric(arrSym2)); 
        Console.WriteLine(CheckIfSymetric(arr)); 

    }
}
