using System;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv prisen for den første vare");

            double first;
            while (!double.TryParse(Console.ReadLine(), out first))
                Console.WriteLine("Skriv et tal");

            Console.WriteLine("Skriv prisen for den anden vare");

            double second;
            while (!double.TryParse(Console.ReadLine(), out second))
                Console.WriteLine("Skriv et tal");

            Console.WriteLine($"Total pris: {first * 0.9 + second * 0.8}");
        }
    }
}