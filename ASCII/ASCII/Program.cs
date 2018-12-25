using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 255; i++)
            {
                
                Console.WriteLine(i+". "+Convert.ToChar(i));
               
            }

            Console.ReadLine();
        }
    }
}
