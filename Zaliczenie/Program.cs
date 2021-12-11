using System;

namespace Zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Administrator adm = new Administrator("123");
                string HasłoAdmin = "Bolek";
                string HasłoKlient = "Nic";
                Użytkownik uż1 = new Użytkownik("Marian Kowalski", false, 1000);
                Użytkownik uż2 = new Użytkownik("Marcin Kowalski", false, 30000);
                Console.WriteLine("Witaj w naszym banku - logowanie");
                Console.WriteLine("Naciśnij 1. żeby zalogować się jako klient");
                Console.WriteLine("Naciśnij 2. żeby zalogować się jako administrator");
                Console.WriteLine("Naciśnij 3. żeby wyjść z aplikacji");
                int logowanie = Convert.ToInt32(Console.ReadLine());
                if (logowanie == 1)
                {
                    Console.WriteLine("Podaj Hasło");

                    if (Console.ReadLine() == HasłoKlient)
                    {
                        Console.WriteLine("Witaj w pulpicie Klienta");
                        Console.WriteLine("Dostępne funkcje:");
                        Console.WriteLine("1.Wpłać/wypłać pieniądze");
                        Console.WriteLine("2.Historia konta");
                        Console.WriteLine("3.Podusmowanie");
                        Console.WriteLine("4.Kredyt");
                        Console.WriteLine("5.Przelew");
                        int Kli = Convert.ToInt32(Console.ReadLine());
                        if (Kli == 1)
                        {
                            Console.WriteLine("1.Wpłata");
                            Console.WriteLine("2.Wypłata");
                            int asd = Convert.ToInt32(Console.ReadLine());
                            if (asd == 1)
                            {
                                Console.WriteLine("Ile chcesz wpłacić pieniędzy? Wpisz sumę.");
                                int wpłata = Convert.ToInt32(Console.ReadLine());
                                int pol = uż2.StanKonta();
                                int wyn = wpłata + pol;
                                Console.WriteLine(wyn);
                            }
                            if (asd == 2)
                            {
                                Console.WriteLine("Ile chcesz wypłacić pieniędzy? Wpisz sumę.");
                                int wpłata = Convert.ToInt32(Console.ReadLine());
                                int pol = uż2.StanKonta();
                                int wyn = pol - wpłata;
                                Console.WriteLine(wyn);
                            }


                        }
                        else if (Kli == 2)
                        {
                            int stan = uż2.StanKonta();
                            Console.WriteLine($"Saldo wynosi: {stan}");
                        }
                        else if (Kli == 3)
                        {

                        }
                        else if (Kli == 4)
                        {
                            Console.WriteLine("Czy chcesz wziąć kredyt?");
                            Console.WriteLine("1.Tak");
                            Console.WriteLine("2.Nie");
                            int kre = Convert.ToInt32(Console.ReadLine());
                            if (kre == 1)
                            {
                                int kredyt1 = uż2.Kredyt();
                                Console.WriteLine($"Po kredycie stan konta wynosi: {kredyt1}");
                            }

                        }
                        else if (Kli == 5)
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Niepoprawne Hasło");
                    }
                }
                else if (logowanie == 2)
                {
                    Console.WriteLine("Podaj Hasło");
                    if (Console.ReadLine() == HasłoAdmin)
                    {
                        Console.WriteLine("Witaj w pulpicie Administratora");
                        Console.WriteLine("Dostępne komendy:");
                        Console.WriteLine("1.Zablokuj");
                        Console.WriteLine("2.Dodaj/usuń konto");
                        Console.WriteLine("3.Podsumowanie");
                        Console.WriteLine("4.Historia Klientów");
                        int Adm = Convert.ToInt32(Console.ReadLine());
                        if (Adm == 1)
                        {

                        }
                        else if (Adm == 2)
                        {
                            Console.WriteLine("1.Dodaj konto");
                            Console.WriteLine("2.Usuń konto");
                            int Adm1 = Convert.ToInt32(Console.ReadLine());
                            if (Adm1 == 1)
                            {
                                adm.DodajUżytkownika(uż1);
                                Console.WriteLine(adm);
                            }
                            if (Adm1 == 2)
                            {
                                adm.UsuńUżytkownika(uż1);
                                Console.WriteLine(adm);
                            }
                        }
                        else if (Adm == 3)
                        {

                        }
                        else if (Adm == 4)
                        {
                            Console.WriteLine(uż1);
                            Console.WriteLine(uż2);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawne hasło");
                    }

                }
                else if (logowanie == 3)
                {
                    break;
                }
            }   
        }
    }
}
