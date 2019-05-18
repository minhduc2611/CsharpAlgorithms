using System;

class demo
{
    // Recursive Binary search
    public static int Recursive_Binary_Search(int value, int[] Arr, int lowerBoundIndex, int upperBoundIndex)
    {
        if(lowerBoundIndex > upperBoundIndex)
        {
            return -1;
        }else{
            int MidIndex = (lowerBoundIndex+upperBoundIndex)/2;
            if(Arr[MidIndex]==value)
                return MidIndex;
            else if(Arr[MidIndex] <value)
                return Recursive_Binary_Search(value,Arr,MidIndex++,upperBoundIndex);
            else
                return Recursive_Binary_Search(value,Arr,lowerBoundIndex,MidIndex--);
        }

    }
    public static void FindElemenInArrayByBinarySearch(int value, int[] Arr){

        int result= Recursive_Binary_Search(value,Arr,0,Arr.Length);
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
            Console.WriteLine("index"+i +": "+ arr[i]);
        }
        FindElemenInArrayByBinarySearch(45,arr);

    }

}

