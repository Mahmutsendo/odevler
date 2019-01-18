using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static double foktoryel(double n)
        {
            if (n == 0)
                return 1;
            else
            return n * foktoryel(n - 1);

        }


        static void Main(string[] args)
        {
          
            double n = Convert.ToDouble(Console.ReadLine());

            double f = foktoryel(n);
            Console.WriteLine(f);
            
            Console.ReadLine();
            
        }
    }
}
