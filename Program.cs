namespace wisielec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra wisielec - wersja uboga");
        poczatek:

            Random r = new Random();
            int rnd = r.Next(1, 3);
            switch (rnd)
            {
                case 1:
                    char[] marycha = new char[7];
                    marycha[0] = 'm';
                    marycha[1] = 'a';
                    marycha[2] = 'r';
                    marycha[3] = 'y';
                    marycha[4] = 'c';
                    marycha[5] = 'h';
                    marycha[6] = 'a';

                    char[] znak = new char[7];
                    for (int j = 0; j < znak.Length; j++)
                    { znak[j] = '_'; }
                    char litera;
                    string walidacja;
                    int odpowiedzi = 0;
                    Console.WriteLine("Ilość liter w wylosowanym słowie:");
                    Console.WriteLine();
                    do
                    {
                        for (int i = 0; i < marycha.Length; i++)
                        {


                            Console.Write(znak[i] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Podaj litere:");
                        walidacja = Console.ReadLine();
                        if (walidacja.Length != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Podano złą ilość znaków!");
                            Console.ResetColor();
                            walidacja = Console.ReadLine();
                        }
                        litera = char.Parse(walidacja);
                        int k = 0;
                        foreach (char item in marycha)
                        {

                            if (item == litera)
                            {
                                znak[k] = litera;
                                odpowiedzi++;
                            }
                            k++;
                        }


                    } while (odpowiedzi < 7);

                    if (odpowiedzi == 7)
                    {
                        foreach (char item2 in marycha)
                        {
                            Console.Write(item2 + " ");
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Udało ci się zgadnąć słowo! Gratulację <3");
                        Console.ResetColor();
                        Console.WriteLine("Jeżeli chcesz zagrać ponownie wpisz 0 lub cokolwiek by zakończyć");
                        string noexit = Console.ReadLine();
                        if (noexit == "0")
                        {
                            goto poczatek;
                        }



                    }


                    break;
                case 2:
                    char[] kebab = new char[5];
                    kebab[0] = 'k';
                    kebab[1] = 'e';
                    kebab[2] = 'b';
                    kebab[3] = 'a';
                    kebab[4] = 'b';

                    char[] znak1 = new char[5];
                    for (int j = 0; j < znak1.Length; j++)
                    { znak1[j] = '_'; }
                    char litera1;
                    string walidacja1;
                    int odpowiedzi1 = 0;
                    Console.WriteLine("Ilość liter w wylosowanym słowie:");
                    Console.WriteLine();
                    do
                    {
                        for (int i = 0; i < kebab.Length; i++)
                        {


                            Console.Write(znak1[i] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Podaj litere:");
                        walidacja1 = Console.ReadLine();
                        if (walidacja1.Length != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Podano złą ilość znaków!");
                            Console.ResetColor();
                            walidacja1 = Console.ReadLine();
                        }
                        litera1 = char.Parse(walidacja1);
                        int k1 = 0;
                        foreach (char item1 in kebab)
                        {

                            if (item1 == litera1)
                            {
                                znak1[k1] = litera1;
                                odpowiedzi1++;
                            }
                            k1++;
                        }


                    } while (odpowiedzi1 < 5);

                    if (odpowiedzi1 == 5)
                    {
                        foreach (char item21 in kebab)
                        {
                            Console.Write(item21 + " ");
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Udało ci się zgadnąć słowo! Gratulację <3");
                        Console.ResetColor();
                        Console.WriteLine("Jeżeli chcesz zagrać ponownie wpisz 0 lub cokolwiek by zakończyć");
                        string noexit = Console.ReadLine();
                        if (noexit == "0")
                        {
                            goto poczatek;
                        }
                       
                    }
                    break;



            }
        }
    }
}