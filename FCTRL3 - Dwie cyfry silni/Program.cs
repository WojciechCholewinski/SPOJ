using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3___Dwie_cyfry_silni
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            for (int i = 0; i < d; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int wynik = Silnia(n);

                // SPOSÓB NA WYŚWIETLANIE SILNI JAKO CIĄG ZNAKÓW - nie prawidłowy dla spoj
                //string myString = wynik.ToString();
                //for (int j = 0; j < myString.Length; j++)
                //{
                //    if (myString.Length==1)
                //    {
                //        Console.Write("0"+" "+myString[j]);
                //    }
                //    else
                //    {
                //        Console.Write(myString[j] + " ");
                //    }
                //}

                int jednosci = wynik % 10;
                int dziesiatki = (wynik / 10) % 10;
                Console.WriteLine(dziesiatki + " " + jednosci);

            }
        }

        private static int Silnia(int v)
        {
            if (v <= 1)
            {
                return 1;
            }
            else if (v > 10)     // gdyż przy silni >10 jednosci i dziesiatki to zawsze '00'
            {
                return 0;
            }
            return v * Silnia(v - 1);
        }
    }
}
