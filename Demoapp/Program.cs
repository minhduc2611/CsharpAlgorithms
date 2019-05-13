using System;

class demo
{
    // Program to find largest and smallest element in an array

    static void FindMinMaxArray(int[] Arr){
        int Max = Arr[0];
        int Min = Arr[0];
        
        for(int i = 1; i < Arr.Length ; i++ ){
            if(Max < Arr[i]){ Max = Arr[i] ;};
            if(Min > Arr[i]){ Min = Arr[i] ;};

        }
        Console.WriteLine($"Max la " + Max + ", va Min la "+Min );
    }
    static void Main(string[] args)
    {
        int[] demoArr = new int[]{42,12,42,3,88};
        FindMinMaxArray(demoArr);
 
    }
}
