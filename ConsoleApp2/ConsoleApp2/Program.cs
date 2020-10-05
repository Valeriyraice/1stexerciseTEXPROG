using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double d = Convert.ToDouble(a);
            if (d % 2 == 0)
            {
                Console.WriteLine("Число четное");
            } else
            {
                Console.WriteLine("Число не четное");
            }
            Console.ReadKey();
        }
    }
}
