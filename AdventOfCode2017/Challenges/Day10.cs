using AdventOfCode2017.Interfaces;
using System;

namespace AdventOfCode2017.Challenges
{
    public class Day10 : IChallengeDay
    {
        private int listLength = 256;
        public int ListLength { get => listLength; set => listLength = value; }

        public string Part01(string input)
        {
            // populate list
            var list = new int[ListLength];
            for (int i = 0; i < ListLength; i++) { list[i] = i; }


            int currentPosition = 0;
            int skipSize = 0;
            var sequences = Array.ConvertAll(input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            foreach (int seq in sequences)
            {
                // select elements in list to be reversed
                int halfSeq = seq / 2; // 6/2=3, 5/2=2
                int seqenceEndIdex = currentPosition + seq - 1;
                for (int i = 0; i < halfSeq; i++) {
                    int startIndex = (currentPosition + i) % ListLength;
                    int endIndex = (seqenceEndIdex - i) % ListLength;

                    // swap / reverse
                    int swap = list[startIndex];
                    list[startIndex] = list[endIndex];
                    list[endIndex] = swap;

                }

                // move to next position
                currentPosition = (currentPosition + seq + skipSize) % ListLength;

                // increase skipsize
                skipSize++;
            }

            return (list[0] * list[1]).ToString() ;
        }

        public string Part02(string input)
        {
            throw new NotImplementedException();
        }

        public string input = @"165,1,255,31,87,52,24,113,0,91,148,254,158,2,73,153";


    }
}