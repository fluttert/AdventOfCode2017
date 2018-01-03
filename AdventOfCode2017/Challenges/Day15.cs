using AdventOfCode2017.Interfaces;
using System;

namespace AdventOfCode2017.Challenges
{
    public class Day15 : IChallengeDay
    {
        public string input = "289 629";

        public string Part01(string input)
        {
            int matches = 0;
            //Convert.ToString(val, 2).PadLeft(4, '0')
            var generatorsStart = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), long.Parse);
            long genA = generatorsStart[0], genB = generatorsStart[1];

            for (int i = 0; i < 40000000; i++)
            {
                genA = (genA * 16807) % 2147483647;
                genB = (genB * 48271) % 2147483647;
                var a1 = Convert.ToString(genA, 2).PadLeft(32, '0');
                var b1 = Convert.ToString(genB, 2).PadLeft(32, '0');
                if (a1.Substring(16) == b1.Substring(16))
                {
                    matches++;
                }
            }

            return matches.ToString();
        }

        public string Part02(string input)
        {
            int matches = 0;
            //Convert.ToString(val, 2).PadLeft(4, '0')
            var generatorsStart = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), long.Parse);
            long genA = generatorsStart[0], genB = generatorsStart[1];

            for (int i = 0; i < 5000000; i++)
            {
                genA = (genA * 16807) % 2147483647;
                while (genA % 4 != 0) { genA = (genA * 16807) % 2147483647; }
                genB = (genB * 48271) % 2147483647;
                while (genB % 8 != 0) { genB = (genB * 48271) % 2147483647; ; }

                var a1 = Convert.ToString(genA, 2).PadLeft(32, '0');
                var b1 = Convert.ToString(genB, 2).PadLeft(32, '0');
                if (a1.Substring(16) == b1.Substring(16))
                {
                    matches++;
                }
            }

            return matches.ToString();
        }
    }
}