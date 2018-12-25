using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sıralamanin_odevleri
{
    class Program
    {
        //The mathod of bubble sorting

        public static double bubble_sort(int[] array)
        {
            double timeofbubble_sort;

            Stopwatch time = new Stopwatch();

            time.Start();


            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            /* Console.WriteLine("the Random array after the  buble sorting");
             foreach (var elment in array)
             {
                 Console.Write(elment + ",");
             }*/
            time.Stop();

            timeofbubble_sort = time.Elapsed.TotalMilliseconds;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("      \t     The time taken for bubble_sort process :" + time.Elapsed);

            return timeofbubble_sort;

        }


        public static double İnsertion_sort(int[] arry)
        {


            double timeofİnsertion_sort;



            Stopwatch time = new Stopwatch();

            time.Start();


            Console.WriteLine();
            Console.WriteLine();


            int newvalue;

            for (int i = 0; i < arry.Length; i++)
            {

                newvalue = arry[i];
                int j = i;



                while (j > 0 && newvalue < arry[j - 1])
                {

                    arry[j] = arry[j - 1];
                    j--;

                }

                arry[j] = newvalue;

                //sorting(arry);

            }

            Console.WriteLine();


            /*  Console.WriteLine("The Random array with inserting sorting:");
              foreach (var elment in arry)
              {
                  Console.Write("{0},", elment);
              }*/

            time.Stop();

            timeofİnsertion_sort = time.Elapsed.TotalMilliseconds;

            Console.WriteLine(" \t     The time taken for İnsertion_sort process :" + time.Elapsed);

            return timeofİnsertion_sort;
        }


        public static double selection_sort(int[] arry)
        {
            double timeofselection_sort;



            Stopwatch time = new Stopwatch();

            time.Start();


            Console.WriteLine();
            Console.WriteLine();

            int temp;
            int minindex;

            for (int i = 0; i < arry.Length; i++)
            {
                minindex = i;

                for (int j = i + 1; j < arry.Length; j++)
                    if (arry[minindex] > arry[j])
                        minindex = j;


                temp = arry[minindex];
                arry[minindex] = arry[i];
                arry[i] = temp;
            }
            /*  Console.WriteLine("The Random array after sorting by the selection  ");
              foreach (var elment in arry)
              {
                  Console.Write("{0},", elment);
              }*/


            time.Stop();

            Console.WriteLine(" \t     The time taken for selection_sort process :" + time.Elapsed);

            timeofselection_sort = time.Elapsed.TotalMilliseconds;

            return timeofselection_sort;
        }

        static void Main(string[] args)
        {



            Stopwatch time = new Stopwatch();

            time.Start();


            int[] arry = new int[100];

            Random rnd = new Random();

            for (int i = 0; i < arry.Length - 1; i++)
            {

                arry[i] = rnd.Next(1, 100);
            }

            /* Console.WriteLine("The Random array without sorting: ");
             for (int i = 0; i < arry.Length; i++)
             {
                 Console.Write(arry[i] + ",");
             }*/


            double timeofbubble_sort = bubble_sort(arry);
            double timeofselection_sort = selection_sort(arry);
            double timeofİnsertion_sort = İnsertion_sort(arry);

            time.Stop();

            double[] timer = new double[3];
            timer[0] = timeofbubble_sort;
            timer[1] = timeofselection_sort;
            timer[2] = timeofİnsertion_sort;

            Array.Sort(timer);

            Console.WriteLine();
            Console.WriteLine();

            if (timer[0] == timeofselection_sort)
                Console.WriteLine("******The fastest one it was the selection sorting******");

            else if (timer[0] == timeofİnsertion_sort)
                Console.WriteLine("******The fastest one it was the insertion sorting******");

            else if (timer[0] == timeofbubble_sort)
                Console.WriteLine("*******The fastest one it was  the bubble sorting*******");



            Console.WriteLine();
            Console.WriteLine(" \t     The time taken for all of 3 process sorting is:" + time.Elapsed);
            Console.ReadLine();
        }
    }
}