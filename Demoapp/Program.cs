using System;

class demo
{
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
        QuickSort(arr, 0, arr.Length - 1);
        Console.Write("\nSorted Array is: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        }
        public static int Partition(int[] Arr, int LeftPointer,int RightPointer)
        {
            int Pavot = Arr[LeftPointer];
            int EndIndex;
            while(true){
                while(Arr[LeftPointer] < Pavot){
                    LeftPointer ++;
                }
                while(Arr[RightPointer] > Pavot ){
                    RightPointer--;
                }
                // loop end : find out the elements needed to be exchanged
                if(LeftPointer<RightPointer){
                //swap
                    int temp = Arr[LeftPointer];
                    Arr[LeftPointer] = Arr[RightPointer];
                    Arr[RightPointer] = temp;
                }
                else{
                    EndIndex = RightPointer;
                    return EndIndex;
                }
            }
        }

        public static void QuickSort(int[] Arr, int LeftPointer,int RightPointer)
        {
            int Defined_Pavot_Index ;

            Defined_Pavot_Index = Partition(Arr,LeftPointer,RightPointer);
            // 2 halves 


            // if pivot at NO# (0) ,  (1) -- > keep.  
            if(Defined_Pavot_Index > 1){ // use if to restrict
                QuickSort(Arr,LeftPointer, Defined_Pavot_Index-1);
            }

            // if pivot at NO# (arr.lenght - 1) ,  (arr.lenght - 2) -- > keep.  
            if(Defined_Pavot_Index + 1< RightPointer )
            {
                QuickSort(Arr,Defined_Pavot_Index+1, RightPointer);
            }

        }

}
