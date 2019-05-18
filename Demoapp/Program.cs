using System;

class demo
{
    // Binary search
    public static int BinarySearch(int value, int[] Arr)
    {
        int LowBoundIndex = 0;
        int HighBoundIndex = Arr.Length-1 ; // because lenght-1 = thelast index in array 
        int MidlleIndex;

        while( LowBoundIndex <= HighBoundIndex)// start moving pointers UNTIL they are equal or low > high
        {// do this 
            MidlleIndex = (LowBoundIndex+HighBoundIndex)/2; // find out the INT midle one ( not double )
            if(Arr[MidlleIndex]==value)
                return MidlleIndex;
            else 
                if(Arr[MidlleIndex] < value)
                    LowBoundIndex = MidlleIndex++; // cut the front array => now is : new Low and High
            else 
                HighBoundIndex = MidlleIndex--; // cut the behind array == > now is : low and new High

        } // the while loop stop and cant find the neeeded element.
        return -1; // -1 represents as " cant find it "

    }
    public static void FindElemenInArrayByBinarySearch(int value, int[] Arr){

        int result= BinarySearch(value,Arr);
        if(result > -1 )
            Console.WriteLine("the element " + value + " is at index " + result);
        else
            Console.WriteLine("can not find the element");
    }

    static void Main(string[] args)
    {        
        int[] arr = new int[]{1,23,34,45,56,67,78,89,123,234,345,456};
        Console.WriteLine("the array : " );

        for(int i = 0 ; i < arr.Length ; i++){
            Console.WriteLine( " index "+i +" : "+ arr[i]);
        }
        FindElemenInArrayByBinarySearch(45,arr);

    }

}

