using AdventOfCode2017.Challenges;
using System;

namespace AdventOfCode2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var day01 = new Day01();

            Console.WriteLine(day01.Part01(day01.InputPart01));
            Console.WriteLine(day01.Part02(day01.InputPart01));
        }
    }
}