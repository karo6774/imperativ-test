using System;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];

            Console.WriteLine("Skriv tre hele tal");
            for (var i = 0; i < numbers.Length; i++)
            {
                int value;
                while (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("Skriv et helt tal");
                numbers[i] = value;
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"Operationer for {num};");
                foreach (var other in numbers)
                {
                    Console.WriteLine($"{num} + {other} = {num + other}");
                    Console.WriteLine($"{num} - {other} = {num - other}");
                    Console.WriteLine($"{num} * {other} = {num * other}");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}