using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade;
            ifade = Console.ReadLine();
            string[] sonuc = ifade.Split(' ');
            Console.WriteLine(" girilen ifade{0}olusan", sonuc.Length);
            foreach(string kelime in sonuc)
            {
                Console.WriteLine(kelime);

            }
            

            Console.ReadKey();
        }
    }
}
