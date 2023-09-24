using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sljedeci = 0;
            int rezultat = 0;

            Console.Write("Unesite broj fibbonacijevog niza: ");
            x = Convert.ToInt32(Console.ReadLine());
            sljedeci.Add(1);
            for (int i = 0; i < x; i++)
            {

                rezultat = rezultat + sljedeci;


            }

            Console.WriteLine(x + ". broj fibbonacijevog niza je: " + rezultat);

            Console.ReadKey();


        }
    }
}
