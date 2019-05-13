using System;

class demo
{
    // Program to find Largest common Multiply of two numbers
    static int gcd(int a, int b){ // gcd = greatest common Denominator

        // = 0
        if(a == 0 || b == 0){
            return a;
        }
        // == nhau 
        if(a == b){
            return a;
        }
        // > 
        if( a > b ){
            return gcd(a-b,b); // recursion 
        }else{
            return gcd(a,b-a);
        }
    }

    static void lcm(int a,int b){
         Console.WriteLine((a*b)/gcd(a,b));
    }

    static void Main(string[] args)
    {
        int a = 15,b=25;
        lcm(a,b);
    }
}
