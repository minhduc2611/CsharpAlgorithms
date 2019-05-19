using System;

class demo
{
    // calculate Power of a number using recursion
    internal static double Power(double num, int exponent )
    {
        if(exponent < 0 ){
        throw new Exception();
        }
        else if(exponent == 0){
            return 1;
        }else if(exponent ==1 )
        {
            return num;
        }else{
            return num * Power(num,exponent-1);
        }
    }
    
    static void Main(string[] args)
    {        
        Console.WriteLine(Power(2,3));
    }

}
