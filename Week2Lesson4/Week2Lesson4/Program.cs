﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Week2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. --------------------------------------------------------

            // deklaracja zmiennych

            Random id = new Random();
            string FirstName;
            string LastName;
            short Age;
            char Gender;
            long Pesel;
            int EmployeeId = id.Next(1, 100000);

            // przypisanie do zmiennych

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input your first name:");
            Console.ResetColor();
            FirstName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input your last name:");
            Console.ResetColor();
            LastName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input your age:");
            Console.ResetColor();
            string age = Console.ReadLine();
            short.TryParse(age, out Age);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input your gender (select: m - man, w - woman):");
            Console.ResetColor();
            string gender = Console.ReadLine();
            char.TryParse(gender, out Gender);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input your pesel:");
            Console.ResetColor();
            string pesel = Console.ReadLine();
            long.TryParse(pesel, out Pesel);

            Console.WriteLine();

            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nGender: {Gender}\n" +
                              $"PESEL: {Pesel}\nID: {EmployeeId}");

            */

            // 2. --------------------------------------------------------

            // deklaracja pustej listy 3 elementowej

            var letters = new List<string>();

            // deklaracja zmiennej

            string letter;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Input letter {i + 1}: ");
                letter = Console.ReadLine();
                letters.Add(letter);
            }

            Console.WriteLine();

            for (int j = 0; j < letters.Count; j++)
            {
                Console.Write($"{letters[j]}, ");
            }

            Console.WriteLine();

            var sortedLetters = letters.OrderBy(p => p).ToList();
            foreach (string element in sortedLetters)
            {
                Console.Write(element);
            }






        }
    }
}
