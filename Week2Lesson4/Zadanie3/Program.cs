using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            double SideLengthA;
            double SideLengthB;
            double Diagonal;

            // pobranie danych od użytkownika

            Console.WriteLine("Podaj długość boku A:");
            string lengthA = Console.ReadLine();
            double.TryParse(lengthA, out SideLengthA);

            Console.WriteLine("Podaj długość boku B:");
            string lengthB = Console.ReadLine();
            double.TryParse(lengthB, out SideLengthB);

            // wyliczenie długości przekątnej

            double PowSideLengthA = Math.Pow(SideLengthA, 2);
            double PowSideLengthB = Math.Pow(SideLengthB, 2);
            Diagonal = Math.Sqrt(PowSideLengthA + PowSideLengthB);
            
            Console.WriteLine($"Przekątna wynosi:\n{Diagonal}");
            Console.WriteLine();
        }
    }
}
