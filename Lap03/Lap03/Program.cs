
using System;

class Program
{
    static void Main()
    {
        int num1,num2 ,count,a ;
        int[] i = new int[100];
        Console.Write("Enter Number start:");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Number end:");        
        num2 = int.Parse(Console.ReadLine());
        while (num1<=num2)
        {
            a=num1++;
            count = a % 7;
            if(count == 0)
            {                                         
                Console.WriteLine("{0}",count);
               
            }            
        }
        Console.ReadLine();
    }
   
}
