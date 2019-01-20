using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=0; i<=153;i++)
            {
                for(int j=0; j<153; j++)
                {
                    if(i*6+j*9==153)
                    {
                        Console.WriteLine("{0}*6+{1}*9=153", i, j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
