using System;

class demo
{
    // POINTER VÀ DELEGATE C# 
    static Func<int,int, int> FunctionPointers = null; // thuộc dạng Delegate :  lấy vào 2 int va trả về 1 int => tổng cộng co 3 int nhé 
    static unsafe void Main(string[] args)
    {
        FunctionPointers = sub;
        Console.WriteLine(FunctionPointers(1,2));  
        FunctionPointers = min;
        Console.WriteLine(FunctionPointers(1,2));  
        FunctionPointers = mul;
        Console.WriteLine(FunctionPointers(1,2));  
    }

    static public int sub(int a, int b){
        return a+b;
    }

    static public int min(int a, int b){
        return a-b;
    }

    static public int mul(int a, int b){
        return a*b;
    }
}
