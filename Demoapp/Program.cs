using System;

class demo
{
    // factorial
    public static int factorial(int i )
    {
        if( i==1 )
            return 1;
        else return i * factorial(i-1);
    }
    
    static void Main(string[] args)
    {        
        Console.WriteLine(factorial(3));
    }

}

