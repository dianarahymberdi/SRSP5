using System;

namespace SRSP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write(" a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" b = ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
