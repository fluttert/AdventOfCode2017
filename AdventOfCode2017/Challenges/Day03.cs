using AdventOfCode2017.Interfaces;
using System;

namespace AdventOfCode2017.Challenges
{
    public class Day03 : IChallengeDay
    {
        /// <summary>
        /// Manhattan distance to the center of a spiral-number-sequence
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Part01(string input)
        {
            int candidate = int.Parse(input);
            int manhattanDistance = 0;
            if (candidate == 1) { return manhattanDistance.ToString(); }

            // determine ring
            int steps = 0;
            int ring = 1;
            while ((ring * ring) < candidate)
            {
                steps++;
                ring += 2;
            }
            int[] minimumsteps = new int[] {
                (ring * ring) - 1* steps,
                (ring * ring) - 3* steps,
                (ring * ring) - 5 *steps ,
                (ring * ring) - 7* steps
            };
            bool found = false;
            for (int i = 0; i <= steps; i++)
            {
                foreach (int minstep in minimumsteps)
                {
                    if (minstep + i == candidate || minstep - i == candidate)
                    {
                        manhattanDistance = steps + i;
                        found = true;
                        break;
                    }
                }
            }
            return manhattanDistance.ToString();
        }

        public string Part02(string input)
        {
            throw new NotImplementedException();
        }

        public string input = "368078";
    }
}