using System;

class demo
{
    // linked list
    public static void bubbleSort(int[] Arr)
    {
        Boolean isSorted = false;
        int LastUnsortIndex = Arr.Length - 1;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < LastUnsortIndex; i++)
            {
                if (Arr[i] > Arr[i + 1])
                {
                    //swap(Arr, Arr[i], Arr[i + 1]);
                 int temp = Arr[i];
                Arr[i] = Arr[i+1];
                Arr[i+1] = temp;
                }
                isSorted = false;
            }
            LastUnsortIndex--;
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
        int[] Arr = new int[] { 17, 3, 9, 45, 12, 4, 5, 23 };

        bubbleSort(Arr);

        for(int a = 0; a< Arr.Length;a++){
        Console.Write(Arr[a]+" ");
        }
    }

}
