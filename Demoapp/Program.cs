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
   static void Main(string[] args) {
         int[] arr = {67, 12, 95, 56, 85, 1, 100, 23, 60, 9}; 
         int n = 10, i;   
         Console.WriteLine("Quick Sort");
         Console.Write("Initial array is: ");   
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         quickSort(arr, 0, 9); 
         Console.Write("\nSorted Array is: ");   
         for (i = 0; i < n; i++) {
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
      Input : array, pointer Left, Pointer right.
      Return : sau khi đã sort xong phần Mục_Tiêu, hàm sẽ trả lại vị trí, nơi mà pointer Left và Right = nhau và = Pavot value 
      
      B1 : gán pivot vào phần tử đầu arr[left]
      B2 : lặp quá trình cho đến khi return được vị trí Pivot 
            {
               Step1: loop cho tới khi tìm thấy ptu lớn hơn pivot ( arr left < pivot value ----> left ++ ) chuyển sang bước 2
               Step2: loop cho tới khi tìm thấy ptu nhỏ hơn pivot ( pivot value  < arr [right] ----> right -- ) . chuyển sang bước 3
               step3: hoán đổi vị trí nếu Bước 2 và 3 đã loop xong (  phát hiện được ( có  ) )
            }
      *
      *
     */
    static public int Partition(int[] arr, int left, int right) { 
         int PivotValue; 
         PivotValue = arr[left];
         while (true) {
            while (arr[left] < PivotValue) {
               left++;
            }    
            while ( PivotValue < arr[right] ) {  
               right--;
            }    
            if (left < right) {
               // swap 
               int temp = arr[right];
               arr[right] = arr[left];
               arr[left] = temp;
            } else {
               return right;
            }
         }

      }

      /*
      *
      *
      *
      funtion quickSort
      
      Mục tiêu : xác định đúng vị trí phần tử đã được sort 
      Input :array ,  2 con trỏ xác định đoạn arr cần sort là LEFT and RIGHT 
      K có return, ARRay sẽ bị biến đổi trong lúc execute hàm. 
      *
      *
     */
      static public void quickSort(int[] arr, int left, int right) {   
         int APivotI;    // APivotI = Assigned_PivotIndex
         if (left < right) {
            APivotI = Partition(arr, left, right);
            if (APivotI > 1) {
               quickSort(arr, left, APivotI - 1);
            }
            if (APivotI + 1 < right) { // make sure after the pivot is more than 1 elements 
               quickSort(arr, APivotI + 1, right);
            }
         }
      } 
}