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

            t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                wynik = 0;
                n = int.Parse(Console.ReadLine());
                for (int j = 1; j <= n; j++)
                {
                    int a = int.Parse(Console.ReadLine());
                    wynik += a;
                }
                Console.WriteLine(wynik);
            }
        }
        
    }
}
