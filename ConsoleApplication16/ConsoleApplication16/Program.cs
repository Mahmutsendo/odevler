using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int kalan, cift = 0, tek = 0;
            int sayi = Convert.ToInt32 (Console.ReadLine());
            while(sayi !=0)
            {
                kalan = sayi % 10;
                if(kalan%2==0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
                sayi = sayi / 10;
            }
            if (cift == tek)
            {
                Console.WriteLine("gırdıgınız sayı dengelidir");
            }
            else
            {
                Console.WriteLine("gırdıgınız sayi dengeli degildir");

            }
            Console.ReadKey();
                
            

        }
    }
}
