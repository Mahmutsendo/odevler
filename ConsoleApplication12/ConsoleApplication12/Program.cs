using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int tavsan = 1520;
            int kuslar = 3256;
            int ay = 0;
            while (tavsan < kuslar)
            {
                kuslar = kuslar + kuslar * 37 / 1000;
                tavsan = tavsan + tavsan * 13 / 1000;
                ay++;


            }
            Console.WriteLine(ay);
            Console.ReadKey();

        }
    }
}
