using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lutfen metin giriniz");
            string cumle = Console.ReadLine();
            string ara = "a";
            string[] dizi = cumle.Split(' ');
            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i].EndsWith(ara))
                {
                    Console.WriteLine(dizi[i]);
                }
                Console.ReadLine();

            }
        }
    }
}
