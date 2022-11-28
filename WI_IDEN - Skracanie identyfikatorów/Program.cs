Console.Write("Podaj ile testów chcesz zrobić: ");
int testy = int.Parse(Console.ReadLine());


string wynik = "Początek";
for (int i = 0; i < testy; i++)
{
    //maksymalna dopuszczalna długość zmiennej
    Console.Write("maksymalna dopuszczalna długość zmiennej: ");
    int max = int.Parse(Console.ReadLine());

    //nazwa zmiennej (o długości l), która będzie podlegać skracaniu
    Console.Write("Teskt któy będzie podlegać skracaniu: ");
    string name = Console.ReadLine();

    int dlugosc = name.Length;

    if (dlugosc <= max)
    {
        wynik = name;
        Console.WriteLine("dlugosc <= max " + wynik);
    }
    else
    {
        int nr = 1;
        for (int q = dlugosc; q > max; q--)
        {

            Console.WriteLine("początek {0} obiegu pętli", nr);

            if (name[name.Length - 1] == '_')
            {
                if (name[name.Length - 1] == name[name.Length - 2])
                {
                    Console.WriteLine("takie same _");
                    q--;
                }
                char[] charsToTrim = { '_' };
                name = name.TrimEnd(charsToTrim);
            }//break or contunue
            else if (Char.IsDigit(name[name.Length - 1]))
            //name[name.Length - 1] == '_')
            {
                if (name[name.Length - 1]== name[name.Length - 2])
                {
                    Console.WriteLine("takie same cyfry");
                    q--;
                }
                name = name.TrimEnd(name[name.Length - 1]);
            }
            else if (name.First() == 'a' || name.First() == 'e' || name.First() == 'i' || name.First() == 'o' || name.First() == 'u' || name.First() == 'y' || name.First() == 'ę' || name.First() == 'ą')
            {
                char[] vowelsToTrim = { 'a', 'e', 'i', 'o', 'u', 'y', 'ę', 'ą' };
                if (vowelsToTrim.Contains(name[1]))
                {
                    Console.WriteLine("takie same samogłoski");
                    q--;
                }
                char tmp = name.First();
                name.TrimStart(tmp);
                //name = name.Remove(name.Length - 1);

                
                //Console.WriteLine(name.First());
                name = name.TrimStart(vowelsToTrim);
                name = tmp + name;

                if (name.Length>max)
                {
                    Console.WriteLine("przedosttania");
                    char tmp2 = name.Last();
                    name = name.TrimEnd(tmp2);
                    name = name.TrimEnd(name[name.Length - 1]);
                    name = name + tmp2;
                    Console.WriteLine("name po trimie na spółgłoskach ostatnich "+name);
                    Console.WriteLine("tmp2 "+tmp2);
                    q--;
                }
            }
            

            Console.WriteLine("Wynik po {0} obiegu pętli: " + name, nr);
            //for (int p = dlugosc; p > max; p--)
            //{
            //    char[] numbersToTrim = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //    string[] frazabez_ = name.Split();
            //    foreach (string poszczegolnalitera in frazabez_)
            //        name = poszczegolnalitera.TrimEnd(numbersToTrim);
            //}
            //wynik = name;
            // tu kontynuować



            nr++;
        }

        //Console.WriteLine("trim _ " + wynik);
        wynik = name;





        Console.WriteLine("---------");
        Console.WriteLine("Ostateczny: " + wynik);
    }
}
//aeibgh1

//|| name.Last()=='$'


// ------------  IFY MUSZĄ BYĆ CHYBA W SIOEBIE ZAGNIEŻDZONE!!! -------------


//char[] charsToTrim = { '_' };
//string[] fraza = imie.Split();
//foreach (string poszczegolnelitery in fraza)
//    Console.WriteLine(poszczegolnelitery.TrimEnd(charsToTrim));

//char[] numbersToTrim = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//string[] frazabez_ = name.Split();
//foreach (string poszczegolnalitera in frazabez_)
//    name = poszczegolnalitera.TrimEnd(numbersToTrim);