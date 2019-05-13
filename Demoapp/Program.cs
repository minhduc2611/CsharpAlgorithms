using System;

class demo
{
    //viet mot ham de trao doi hai gia tri bang POINTER
    /*
    * POINTER: 
    *
    * A pointer is nothing but a variable that holds the memory address of another type
    * Declaring a Pointer type : type *variable_name; --> e.g : int *num1
    * 
    * The &num1 gives the memory address of the variable num1, which we can assign to a pointer variable 
    * 
    * Remember that in C# any code involving pointers requires an unsafe context.
    *
    * apply :
    * Binary search, heap ,tree,graph,linked list ...... 
    *
    *
     */
    

     static unsafe void swap(int* num1,int* num2){
         int temp;
         temp = *num1;
         *num1 = *num2;
         *num2 = temp;
    }
    static unsafe void Main(string[] args)
    {
        Console.WriteLine("num 1");
        int num1 = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("num 2");
        int num2 = Convert.ToInt32( Console.ReadLine());

        swap(&num1, &num2);

        Console.WriteLine($"\nSau khi trao doi:");
        Console.WriteLine($"\nSo thu nhat:"+ num1);
        Console.WriteLine($"\nSo thu hai:"+ num2);
    }

}
