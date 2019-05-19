using System;

class demo
{
    // Quick Sort

    /*
    *
    * Quick sort follows recursive algorithm
    *
    * We find the pavot which devides the array into 2 halves 
    *
    *then we find the pavot for these halves ==> which is ultimately give us the sorted array 
    */
    static void Main(string[] args)
    {
        int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
        int n = 10, i;
        Console.WriteLine("Quick Sort");
        Console.Write("Initial array is: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        quickSort(arr, 0, arr.Length - 1);
        Console.Write("\nSorted Array is: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    /*
    *
    *
    *
      funtion Partition
      
      Mục tiêu : các phàn tử bé hơn pivot value thì sang trái pivot, 
                  nguọc lại các phần tử lớn hơn Pivotvalue thì sang phải 
      Input : array, pointer BeginPointer, Pointer LastPointer.
      Return : sau khi đã sort xong phần Mục_Tiêu, hàm sẽ trả lại vị trí, nơi mà pointer BeginPointer và LastPointer = nhau và = Pavot value 
      
      B1 : gán pivot vào phần tử đầu arr[BeginPointer]
      B2 : lặp quá trình cho đến khi return được vị trí Pivot 
            {
               Step1: loop cho tới khi tìm thấy ptu lớn hơn pivot ( arr BeginPointer < pivot value ----> BeginPointer ++ ) chuyển sang bước 2
               Step2: loop cho tới khi tìm thấy ptu nhỏ hơn pivot ( pivot value  < arr [LastPointer] ----> LastPointer -- ) . chuyển sang bước 3
               step3: hoán đổi vị trí nếu Bước 2 và 3 đã loop xong (  phát hiện được ( có  ) )
            }
      *
      *
     */
    static public int Partition(int[] arr, int BeginPointer, int LastPointer)
    {
        int PivotValue;
        PivotValue = arr[BeginPointer];
        while (true)
        {
            while (arr[BeginPointer] < PivotValue)
            {
                BeginPointer++;
            }
            while (PivotValue < arr[LastPointer])
            {
                LastPointer--;
            }
            if (BeginPointer < LastPointer)
            {
                // swap 
                int temp = arr[LastPointer];
                arr[LastPointer] = arr[BeginPointer];
                arr[BeginPointer] = temp;
            }
            else
            {
                return LastPointer;
            }
        }

    }

    /*
    *
    *
    *
    funtion quickSort

    Mục tiêu : xác định đúng vị trí phần tử đã được sort 
    Input :array ,  2 con trỏ xác định đoạn arr cần sort là BeginPointer and LastPointer 
    K có return, ARRay sẽ bị biến đổi trong lúc execute hàm. 
    *
    *
   */
    static public void quickSort(int[] arr, int BeginPointer, int LastPointer)
    {
        int Defined_PivotIndex; 
        if (BeginPointer < LastPointer)
        {
            Defined_PivotIndex = Partition(arr, BeginPointer, LastPointer);
            // after defind  Pivotindex
            // the First half of the array 
            if (Defined_PivotIndex > 1)
            {   
                quickSort(arr, BeginPointer, Defined_PivotIndex - 1);
            }

            // the Second half of the array
            if (Defined_PivotIndex + 1 < LastPointer)
            { // make sure after the pivot is more than 1 elements 
                quickSort(arr, Defined_PivotIndex + 1, LastPointer);
            }
        }
    }
}