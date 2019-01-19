using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        public static double foktoryel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * foktoryel(n - 1);

        }


        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            double f = foktoryel(n);
            Console.WriteLine(f);

            Console.ReadLine();

        }
    }
}
