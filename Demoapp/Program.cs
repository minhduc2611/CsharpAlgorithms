using System;

class demo
{
    //viet mot ham de trao doi hai gia tri bang POINTER
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
