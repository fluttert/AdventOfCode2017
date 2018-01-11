using AdventOfCode2017.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017.Challenges
{
    public class Day17 : IChallengeDay
    {
        public string Part01(string input)
        {
            int stepsForward = int.Parse(input);
            int[] buffer = new int[2018];
            buffer[1] = 1;
            int length = 2, position = 1;
            while (length < 2018) {
                position = (position + stepsForward) % length;

                // move all stuff further
                for (int i = length; i > position; i--) {
                    buffer[i] = buffer[i - 1];
                }
                buffer[position+1] = length;

                position++;
                length++;
            }
            return buffer[((position + 1) % length)].ToString();
        }

        public string Part02(string input)
        {
            int bufferLength = 50000000;
            int stepsForward = int.Parse(input);
            int length = 2, position = 1, result = 1 ;
            while (length < bufferLength)
            {
                position = (position + stepsForward) % length;
                if (position == 0) { result = length; }
                position++;
                length++;
            }

           

            return result.ToString();
        }

        public string input = "376";
    }
}
