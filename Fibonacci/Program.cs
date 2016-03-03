using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbrito.Essentials.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int lim_low, lim_up;
            int a = 0, b = 1, c;

            Console.WriteLine("Enter First Value: ");
            lim_low = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Last Value: ");
            lim_up = Convert.ToInt32(Console.ReadLine());

            while (a < lim_up)
            {
                if (a > lim_low)
                    Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();

        }  
    }
}
