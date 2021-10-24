using System;

namespace Ohms.law_hopooe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I value  :");
            int I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("R value  :");
            int R = Convert.ToInt32(Console.ReadLine());
            int result = I * R;
            Console.WriteLine(" V = " + result);

        }
    } 
}
