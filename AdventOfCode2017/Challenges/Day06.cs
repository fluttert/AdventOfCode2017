using AdventOfCode2017.Interfaces;
using System;
using System.Collections.Generic;

namespace AdventOfCode2017.Challenges
{
    public class Day06 : IChallengeDay
    {
        public string Part01(string input)
        {
            var memoryBanks = Array.ConvertAll(input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            var states = new HashSet<string>();
            int cycles = 0, memoryLength = memoryBanks.Length;
            string state = String.Join("", memoryBanks);
            while (!states.Contains(state))
            {
                states.Add(state);
                cycles++;

                // determine max
                int highNumber = -1, highPos = -1;
                for (int i = 0; i < memoryBanks.Length; i++)
                {
                    if (memoryBanks[i] > highNumber)
                    {
                        highNumber = memoryBanks[i];
                        highPos = i;
                    }
                }

                // clear and redistribute
                memoryBanks[highPos] = 0;
                for (int i = (highPos + 1) % memoryLength; highNumber > 0; i = (i + 1) % memoryLength)
                {
                    memoryBanks[i]++;
                    highNumber--;
                }

                // create new state
                state = String.Join("", memoryBanks);
            }

            return cycles.ToString();
        }

        public string Part02(string input)
        {
            throw new NotImplementedException();
        }

        public string input = @"10	3	15	10	5	15	5	15	9	2	5	8	5	2	3	6";
    }
}