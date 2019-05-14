using System;
using System.Linq;

namespace KarolineRasmussen.ImperativTestS1.FærdighedsDel.Opg7
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {12, 51, 34, 12, 41}.ToList();

            foreach (var num in nums)
                Console.WriteLine(num);
            
            var negativeSum = nums.Skip(1).Aggregate(nums.First(), (acc, it) => acc - it);
            var produkt = nums.Skip(1).Aggregate(nums.First(), (acc, it) => acc * it);
            
            Console.WriteLine($"Negativ sum: {negativeSum}");
            Console.WriteLine($"Produkt sum: {produkt}");
        }
    }
}