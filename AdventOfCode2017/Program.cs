﻿using AdventOfCode2017.Challenges;
using System;
using System.Diagnostics;

namespace AdventOfCode2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // challenge
            var day = new Day04();

            // timing
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            

            //Console.WriteLine(day.Part01(day.input));
            Console.WriteLine(day.Part02(day.input));
            Console.WriteLine($"Took {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();

            Console.WriteLine(day.Part02Parallel(day.input));

            // timing
            Console.WriteLine($"Took {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}