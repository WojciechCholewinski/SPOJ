Console.Write("Podaj ile testów chcesz zrobić: ");
int testy = int.Parse(Console.ReadLine());


string wynik;
for (int i = 0; i < testy; i++)
{
    Console.Clear();
    //maksymalna dopuszczalna długość zmiennej
    Console.Write("Maksymalna dopuszczalna długość zmiennej: ");
    int max = int.Parse(Console.ReadLine());

    //nazwa zmiennej (o długości l), która będzie podlegać skracaniu
    Console.Write("Teskt któy będzie podlegać skracaniu:\t\t");
    string name = Console.ReadLine();

    string namepoczątkowy = name;


    if (name.Length <= max)
    {
        wynik = name;
        Console.WriteLine("dlugosc <= max, więc oczekiwany wynik to: " + wynik);
    }
    else
    {

        //TODO: odwórcić kolejność znaków w tablicy name tzn z 012345 na 543210, następnie poiterować foreach-em a w środku usuwać "_" i po każdym usunięciu sprawdzać if-em czy Lenght nie jest już równa zmiennej max. Jeśli tak, to w if-ie umieścić break lub contineu?. Jeśli nieto iść do if else-a odejmującego cyfry. Co ważne! usunąć sprawdzanie ifami ostatniego znaku bo to chyba nie o to chodzi w tym zadaniu jaki  jest stricte ostatni znak.
        // usunąc wgl tego for-a wtedy bo wszytskie foreach-e zostaną po prostu w powyższym elsie.

        char[] tablicaname = namepoczątkowy.ToCharArray();
        Array.Reverse(tablicaname);

        
        
        //Array.Reverse(tablicaname);
        //Console.WriteLine("1:");
        //foreach (var item in tablicaname)
        //{
        //    Console.Write(item);
        //}

        for (int l = 0; l < tablicaname.Length; l++)
        {
            if (tablicaname[l] == '_')
            {
                tablicaname = new string(tablicaname).Remove(l, 1).ToCharArray();
                if (tablicaname.Length == max)
                {
                    goto end;
                }
            }
        }
        for (int l = 0; l < tablicaname.Length; l++)
        {
            if (Char.IsDigit(tablicaname[l]))
            {
                tablicaname = new string(tablicaname).Remove(l, 1).ToCharArray();
                if (tablicaname.Length == max)
                {
                    goto end;
                }
            }
        }
        int firsttime = 0;
        for (int l = (tablicaname.Length)-1; l >= 0; l--)
        {
            if (tablicaname[l] == 'a' || tablicaname[l] == 'e' || tablicaname[l] == 'i' || tablicaname[l] == 'o' || tablicaname[l] == 'u' || tablicaname[l] == 'y' || tablicaname[l] == 'ę' || tablicaname[l] == 'ą' || tablicaname[l] == 'A' || tablicaname[l] == 'E' || tablicaname[l] == 'I' || tablicaname[l] == 'O' || tablicaname[l] == 'U' || tablicaname[l] == 'Y' || tablicaname[l] == 'Ę' || tablicaname[l] == 'Ą')
            {
                firsttime ++;
                if (firsttime != 1)
                {
                    tablicaname = new string(tablicaname).Remove(l, 1).ToCharArray();
                }
                
                if (tablicaname.Length == max)
                {
                    goto end;
                }
            }
        }
        for (int l = 0; l < tablicaname.Length; l++)
        {
            if (tablicaname.Length == max)
            {
                goto end;
            }
            else
            {
                tablicaname = new string(tablicaname).Remove(1, 1).ToCharArray();
            }
        }


    end:
        Array.Reverse(tablicaname);
        Console.Write("\nTekst już poddany algorytmowi skracania:\t");
        foreach (var item in tablicaname)
        {
            Console.Write(item);
        }

        


        // -----------------------   PIERWOTNY (błędny) SPOSÓB W JAKI PRÓBOWAŁEM ROZWIĄZAĆ TO ZADANIE   -----------------------
        //int dlugosc = name.Length;
        //int nr = 1;
        //for (int q = dlugosc; q > max; q--)
        //{

        //    Console.WriteLine("początek {0} obiegu pętli", nr);

        //    if (name[name.Length - 1] == '_')
        //    {
        //        if (name[name.Length - 1] == name[name.Length - 2])
        //        {
        //            Console.WriteLine("takie same _");
        //            q--;
        //        }
        //        char[] charsToTrim = { '_' };
        //        name = name.TrimEnd(charsToTrim);
        //    }
        //    else if (Char.IsDigit(name[name.Length - 1]))
        //    //name[name.Length - 1] == '_')
        //    {
        //        if (name[name.Length - 1] == name[name.Length - 2])
        //        {
        //            Console.WriteLine("takie same cyfry");
        //            q--;
        //        }
        //        name = name.TrimEnd(name[name.Length - 1]);
        //    }
        //    else if (name.First() == 'a' || name.First() == 'e' || name.First() == 'i' || name.First() == 'o' || name.First() == 'u' || name.First() == 'y' || name.First() == 'ę' || name.First() == 'ą' || name.First() == 'A' || name.First() == 'E' || name.First() == 'I' || name.First() == 'O' || name.First() == 'U' || name.First() == 'Y' || name.First() == 'Ę' || name.First() == 'Ą')
        //    {
        //        char[] vowelsToTrim = { 'a', 'e', 'i', 'o', 'u', 'y', 'ę', 'ą', 'A', 'E', 'I', 'O', 'U', 'Y', 'Ę', 'Ą' };
        //        if (vowelsToTrim.Contains(name[1]))
        //        {
        //            Console.WriteLine("takie same samogłoski");
        //            q--;
        //        }
        //        char tmp = name.First();
        //        name.TrimStart(tmp);
        //        //name = name.Remove(name.Length - 1);


        //        //Console.WriteLine(name.First());
        //        name = name.TrimStart(vowelsToTrim);
        //        name = tmp + name;

        //        if (name.Length > max)
        //        {
        //            Console.WriteLine("przedosttania");
        //            char tmp2 = name.Last();
        //            name = name.TrimEnd(tmp2);
        //            name = name.TrimEnd(name[name.Length - 1]);
        //            name = name + tmp2;
        //            Console.WriteLine("name po trimie na spółgłoskach ostatnich " + name);
        //            Console.WriteLine("tmp2 " + tmp2);
        //            q--;
        //        }
        //    }


        //    Console.WriteLine("Wynik po {0} obiegu pętli: " + name, nr);
        //    //for (int p = dlugosc; p > max; p--)
        //    //{
        //    //    char[] numbersToTrim = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    //    string[] frazabez_ = name.Split();
        //    //    foreach (string poszczegolnalitera in frazabez_)
        //    //        name = poszczegolnalitera.TrimEnd(numbersToTrim);
        //    //}
        //    //wynik = name;
        //    // tu kontynuować



        //    nr++;
        //}

        ////Console.WriteLine("trim _ " + wynik);
        //wynik = name;





        //Console.WriteLine("---------");
        //Console.WriteLine("Początkowy: " + namepoczątkowy);
        //Console.WriteLine("Ostateczny: " + wynik);


    }
    Console.WriteLine("\n\n........................");
    Console.Write("Wciśnij dowolny klawisz.");
    Console.ReadKey();
}