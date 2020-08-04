using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sposób 1 -------------------------------------------------------

            // deklaracja zmiennych

            char letter1;
            char letter2;
            char letter3;

            // przypisanie do zmiennych

            letter1 = 'a';
            letter2 = 'b';
            letter3 = 'c';

            // wypisanie w odwrotnej kolejności

            Console.Write($"{ letter3}, {letter2}, {letter1}");
            Console.WriteLine('\n');

            // Sposób 2 -------------------------------------------------------

            // deklaracja pustej listy

            var letters = new List<string>();

            // deklaracja zmiennej

            string letter;

            // pętla, która dodaje do listy litery pobrane od użytkownika

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Input letter {i + 1}: ");
                letter = Console.ReadLine();
                letters.Add(letter);
            }

            Console.WriteLine();

            // pętla, która wyświetla zawartość listy

            for (int j = 0; j < letters.Count; j++)
            {
                Console.Write($"{letters[j]}, ");
            }

            Console.WriteLine();

            // sortowanie listy w odwrotnej kolejności i wyświetlenie zawartości

            letters.Reverse();
            foreach (string element in letters)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{element}, ");
                Console.ResetColor();
            }

            Console.WriteLine('\n');
        }
    }
}
