using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            agt:
            string metin = Console.ReadLine();
            int uzn = metin.Length;

            Stack yagin = new Stack();

            string ters_ifade = "";

            for (int i = 0; i < uzn; i++)
            {
                yagin.Push(metin.Substring(i, 1));
            }
            for (int i = 0; i < uzn; i++)
            {
                ters_ifade = ters_ifade + yagin.Pop();
            }

            Console.WriteLine(ters_ifade);

            if (metin == ters_ifade)
            {
                Console.WriteLine("Girindiniz metin polidromdur");
            }

            else
            {

                Console.WriteLine("Girindiniz metin polidrom degildir");

            }
            goto agt;

            Console.ReadLine();

        }
    }
}