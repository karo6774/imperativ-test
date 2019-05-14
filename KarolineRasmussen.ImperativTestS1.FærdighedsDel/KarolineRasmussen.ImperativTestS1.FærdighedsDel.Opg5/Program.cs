using System;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg5
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
                Console.WriteLine("Skriv en tal");

            Console.WriteLine($"Moms af prisen: {price * 0.25}");
        }
    }
}
