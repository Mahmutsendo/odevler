using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınavCalışma
{
    class Program
    {
        static void KacKelime()
        {
            string ifade;
            int sonuc = 0;
            Console.Write("Bir ifade giriniz: ");
            ifade = Console.ReadLine();

            string[] MySpilt = ifade.Split();
            sonuc = MySpilt.Length;
            Console.WriteLine("girilen ifade {0} kelimeden oluşur.", sonuc);


        }
        static void Main(string[] args)
        {
            KacKelime();
            Console.Read();

        }
    }
}