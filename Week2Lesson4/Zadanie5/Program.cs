﻿using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            string FirstName;
            string LastName;
            string PhoneNumber;
            string Email;
            string Age;
            string Gender;
            string Height;
            string Weight;
            string EyesColor;
            string HairColor;

            // przypisanie do zmiennych

            Console.WriteLine("Podaj swoje dane personalne");

            Console.Write("Imię: ");
            FirstName = Console.ReadLine();

            Console.Write("Nazwisko: ");
            LastName = Console.ReadLine();

            Console.Write("Numer telefonu: ");
            PhoneNumber = Console.ReadLine();
            int phoneNumber = int.Parse(PhoneNumber);

            Console.Write("Adres email: ");
            Email = Console.ReadLine();

            Console.Write("Wiek: ");
            Age = Console.ReadLine();
            short age = short.Parse(Age);

            Console.Write("Płeć: ");
            Gender = Console.ReadLine();

            Console.Write("Wzrost: ");
            Height = Console.ReadLine();
            short height = short.Parse(Height);

            Console.Write("Waga: ");
            Weight = Console.ReadLine();
            double weight = double.Parse(Weight);

            Console.Write("Kolor oczu: ");
            EyesColor = Console.ReadLine();

            Console.Write("Kolor włosów: ");
            HairColor = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Imię: {FirstName}\nNazwisko: {LastName}\nNumer telefonu: {PhoneNumber}\n" +
                $"Adres email: {Email}\nWiek: {Age}\nPłeć: {Gender}\nWzrost: {Height}\nWaga: {Weight}\n" +
                $"Kolor oczu: {EyesColor}\nKolor włosów {HairColor}");








        }
    }
}
