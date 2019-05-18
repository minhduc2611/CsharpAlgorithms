using System;

class demo
{
    // factorial
    public static int Sum_of_digits(int num )
    {
        if( num==0 )
            return 0 ;
        else return num%10 + Sum_of_digits(num/10);
    }
    
    static void Main(string[] args)
    {        
        Console.WriteLine(Sum_of_digits(13));
    }

}
