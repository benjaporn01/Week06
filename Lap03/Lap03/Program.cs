
using System;

class Program
{
    static void Main()
    {
        int val;   // do not initial value
        
        Console.WriteLine("Enter number:");
        val = int.Parse(Console.ReadLine());
        refMethod(ref val);
        Console.ReadLine();
    }

    static void refMethod(ref int i)
    {
        i = i + 1;
    }
}
