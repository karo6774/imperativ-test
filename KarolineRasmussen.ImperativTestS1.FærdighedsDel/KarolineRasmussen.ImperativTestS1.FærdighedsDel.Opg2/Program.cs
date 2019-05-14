using System;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej bruger. Indtast dit navn her:");
            var name = Console.ReadLine();
            Console.WriteLine($"Dit navn er {name}");
        }
    }
}