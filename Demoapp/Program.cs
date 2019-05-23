using System;

class demo
{
    // linked list
    public static void SelectionSort(int[] Arr){
        // int i=0;
        // while(i< Arr.Length-1){
        //     int PointerFirstIndex = i;
        //     int PointerSecondIndex = i+1;
        //     int PointerMinValue=Arr[i+1];
        //     int MinIndex = i+1;
        //     for(int PointerMinIndex = PointerSecondIndex+1;PointerMinIndex<Arr.Length-1;PointerMinIndex++){
        //         if(Arr[PointerMinIndex] < PointerMinValue)
        //             MinIndex = PointerMinIndex;
            
        //     }
        //         if(PointerMinValue < PointerFirstIndex){
        //             swap(Arr,MinIndex,PointerFirstIndex);
        //         }
        //         i++;
        // }

        // int SortedIndex = 0;
        // while(SortedIndex < Arr.Length-1){
        //     int Min = Arr[0];
        //     int MinIndex = 0;
        //     for(int i =0; i< Arr.Length-1;i++){
        //         if(Min > Arr[i]){
        //             Min = Arr[i];
        //             MinIndex = i;
        //         }
        //     }
        //     swap(Arr,SortedIndex,MinIndex);
        //     SortedIndex ++;
        // }

        int Min;
        for(int i = 0; i < Arr.Length; i++){
            Min = i;
            for(int j = i+1; j < Arr.Length; j ++){
                if(Arr[Min]>Arr[j]){
                    swap(Arr,Min,j);
                }
            }
        }
    }

    public static void swap(int[] Arr, int a, int b)
    {
        int temp = Arr[a];
        Arr[a] = Arr[b];
        Arr[b] = temp;
    }

    static void Main(string[] args)
    {
        int[] Arr = new int[]{7,3,9,8,4,1,5,6};
        SelectionSort(Arr);
        for(int i =0;i < Arr.Length; i++){
            Console.Write(Arr[i]+" ");
        }
        // Console.Write(SelectionSort(Arr));

    }

}
