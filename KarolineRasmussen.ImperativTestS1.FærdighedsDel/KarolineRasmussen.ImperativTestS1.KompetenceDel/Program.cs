using System;
using System.Collections.Generic;
using System.Linq;

namespace KarolineRasmussen.ImperativTestS1.KompetenceDel
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>();

            while (true)
            {
                Console.WriteLine("Vælg en mulighed");
                Console.WriteLine(" 1 - Tilføj vare");
                Console.WriteLine(" 2 - Udskriv total");
                Console.WriteLine(" 3 - Exit");
                Console.Write(" > ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Skriv et helt tal mellem 1 og 3");
                    Console.Write(" > ");
                }

                Console.WriteLine();
                
                switch (choice)
                {
                    case 1:
                    {
                        while (true)
                        {
                            Console.WriteLine("Skriv navn på varen, eller 'exit' for at gå tilbage:");
                            string name = Console.ReadLine();
                            if (name == "exit")
                                break;

                            Console.WriteLine("Skriv prisen på varen:");
                            double price;
                            while (!double.TryParse(Console.ReadLine(), out price))
                                Console.WriteLine("Skriv et tal");

                            items.Add(new Item(name, price));
                            
                            Console.WriteLine();
                        }

                        break;
                    }

                    case 2:
                    {
                        foreach (var item in items)
                            Console.WriteLine($" {item.Name}: {item.Price}");
                        Console.WriteLine($"Total: {items.Sum(it => it.Price)}");
                        Console.WriteLine("Tryk på en tast for at gå tilbage...");
                        Console.ReadKey();
                        break;
                    }

                    case 3:
                        Console.WriteLine("Farvel besked.");
                        return;
                }
                
                Console.WriteLine();
            }
        }
    }

    struct Item
    {
        public readonly string Name;
        public readonly double Price;

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}