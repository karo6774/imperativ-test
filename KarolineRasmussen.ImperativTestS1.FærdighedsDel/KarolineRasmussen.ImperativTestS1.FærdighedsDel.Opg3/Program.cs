using System;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et helt tal mellem 1 og 10");
            int i;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out i))
                    Console.WriteLine("Skriv et helt tal mellem 1 og 10");
                if (i >= 1 && i <= 10)
                    break;
                else
                    Console.WriteLine("Skriv et helt tal mellem 1 og 10");
            }

            if (i > 5)
                Console.WriteLine("Større end 5");
            else if (i < 5)
                Console.WriteLine("Mindre end 5");
            else
                Console.WriteLine("Præcist 5");
        }
    }
}
