using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNO_DOD___Proste_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; // ilość prób
            int n; //liczba liczb do dodania
            int wynik;
            string ciągcyfr;

            t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                wynik = 0;
                n = int.Parse(Console.ReadLine());
                ciągcyfr = Console.ReadLine();

                string[] cyfry = ciągcyfr.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    int a = int.Parse(cyfry[j]);
                    wynik += a;
                }
                Console.WriteLine(wynik);
            }
        }

    }
}
