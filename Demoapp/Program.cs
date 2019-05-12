using System;

class demo
{
    static unsafe void Main(string[] args)
    {
        int x =100;
        int* px = &x;

        Console.WriteLine(*px);
    }
}
