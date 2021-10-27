using System;

namespace Ohms.law_hopooe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I value  :");
            decimal I = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("R value  :");
            decimal R = Convert.ToDecimal(Console.ReadLine());
            decimal result = I * R;
            Console.WriteLine(" V = " + result);
            Console.ReadLine();
            

        }
        
    } 
}
