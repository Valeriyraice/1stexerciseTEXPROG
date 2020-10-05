using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int d, c, s;
            d = 1;
            c = 1;
            s = d + c;
            Console.Write("{0} ", d);
            Console.Write("{0} ", c);
            while (b >= s)
            {
                s = d + c;

                Console.Write("{0} ", s);

                d = c;
                c = s;
            }
            Console.ReadKey();
        }
    }
}
