using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST___Life__the_Universe__and_Everything
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string s;
            do
            {
                s = Console.ReadLine();
                lista.Add(s);
            } while (s != "42");
            lista.Remove(lista.Last());
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
