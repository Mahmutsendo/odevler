using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3;
            s1 = DateTime.Now.Millisecond;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            s2 = DateTime.Now.Millisecond;
            s3 = s2 - s1;
            Console.WriteLine(s3);
            Console.ReadKey();
                
        }
    }
}
