//using System.Collections.Generic;
//int t = int.Parse(Console.ReadLine());
//string [] tablica = new string[t];
//int n;
//for (int i = 0; i < t; i++)
//{
//    n = int.Parse(Console.ReadLine());
//    //string[] tablica = new string[n];

//    tablica = Console.ReadLine().Split();

//    string tmp = tablica.First();
//    List<string> list = new List<string>();
//    for (int j = 0; j < tablica.Length; j++)
//    {
//        list.Add(tablica[j]);
//    }
//    list.Add(tmp);
//    list.RemoveAt(0);
//    //list.RemoveAt(1);
//    tablica = list.ToArray();
//    //foreach (var item in tablica)
//    //{
//    //    item;
//    //}
//    //Console.WriteLine();
//}
//foreach (var item in tablica)
//{
//    Console.Write(item);
//}
////Console.Write(tablica.ToString());

int t, n;
string[] tab;
t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    n = int.Parse(Console.ReadLine());
    tab = new string[n];

    tab = Console.ReadLine().Split();

    for (int j = 1; j < n; j++)
    {
        Console.Write(tab[j] + " ");

    }
    Console.WriteLine(tab[0]);
}

