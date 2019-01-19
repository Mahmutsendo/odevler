using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                int kok = Convert.ToInt32(Math.Sqrt(i));
                if (kok * kok == i)
                    Console.WriteLine(i);
            }
                Console.ReadKey();
            
        }
    }
}
