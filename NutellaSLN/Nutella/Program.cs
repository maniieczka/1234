﻿namespace Nutella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siema,celem aplikacji jest to zebys podał dwie liczby całkowite i otrzymał wynik dodawania lub odejmowania");
            Console.WriteLine("Jeśli chcesz otrzymać wynik dodawania wpisz +, jeśli chcesz otrzymać wynik odejmowania wpisz -");
            string działanie;
            działanie = Console.ReadLine();
            if (działanie == "+")
            {
                Console.WriteLine("Otrzymasz wynik dodawania, podaj pierwszą liczbę całkowitą");
                string pierwszaLiczbaCałkowita = Console.ReadLine();
                int Pierwsza = int.Parse(pierwszaLiczbaCałkowita);
                Console.WriteLine("Otrzymasz wynik dodawania, podaj drugą liczbę całkowitą");
                string drugaLiczbaCałkowita = Console.ReadLine();
                int Druga = int.Parse(drugaLiczbaCałkowita);
                int Wynik = Pierwsza + Druga;
                Console.WriteLine("Wynik to:" + Wynik);
            }
            if (działanie == "-")
            {
                Console.WriteLine("Otrzymasz wynik odejmowania, podaj pierwszą liczbę całkowitą");
                string pierwszaLiczbaCałkowita = Console.ReadLine();
                int Pierwsza = int.Parse(pierwszaLiczbaCałkowita);
                Console.WriteLine("Otrzymasz wynik odejmowania, podaj drugą liczbę całkowitą");
                string drugaLiczbaCałkowita = Console.ReadLine();
                int Druga = int.Parse(drugaLiczbaCałkowita);
                int Wynik = Pierwsza - Druga;
                Console.WriteLine("Wynik to:" + Wynik);
            }
        } 
    }
}