using AdventOfCode2017.Interfaces;

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

            // shortest way in cross-form
            int[] minimumsteps = new int[] {
                (ring * ring) - 1* steps,
                (ring * ring) - 3* steps,
                (ring * ring) - 5 *steps,
                (ring * ring) - 7* steps
            };

            // calculate the steps from the cross-form
            for (int i = 0; i <= steps; i++)
            {
                foreach (int minstep in minimumsteps)
                {
                    if (minstep + i == candidate || minstep - i == candidate)
                    {
                        manhattanDistance = steps + i;
                        break;
                    }
                }
                if (manhattanDistance != 0) { break; }
            }
            return manhattanDistance.ToString();
        }

        public string Part02(string input)
        {
            int result = 0;
            int dimension = 501;
            int offset = (dimension / 2) + 1;
            int candidate = int.Parse(input);

            // create a grid, the last one had a minimum steps of 303, and this thing should grow very fast
            // estimated guess is that the required spiral will not be bigger then 501*501
            int[][] grid = new int[dimension][];
            for (int i = 0; i < dimension; i++) { grid[i] = new int[dimension]; }
            grid[offset][offset] = 1;

            int curX = offset, curY = offset;
            Direction heading = Direction.EAST;
            while (result == 0)
            {
                // some code to get the sprial in the right direction
                Direction nextHeading = heading;
                if (heading == Direction.EAST)
                {
                    curX++;
                    if (grid[curX][curY + 1] == 0) { nextHeading = Direction.NORTH; }
                }
                if (heading == Direction.WEST)
                {
                    curX--;
                    if (grid[curX][curY - 1] == 0) { nextHeading = Direction.SOUTH; }
                }
                if (heading == Direction.NORTH)
                {
                    curY++;
                    if (grid[curX - 1][curY] == 0) { nextHeading = Direction.WEST; }
                }
                if (heading == Direction.SOUTH)
                {
                    curY--;
                    if (grid[curX + 1][curY] == 0) { nextHeading = Direction.EAST; }
                }

                // captain, should be change course?
                if (heading != nextHeading) { heading = nextHeading; }

                // get me the sum of adjecent squares
                int sum = 0;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        sum += grid[curX + i][curY + j];
                    }
                }
                grid[curX][curY] = sum;
                if (sum > candidate)
                {
                    result = sum;
                }
            }

            return result.ToString();
        }

        private enum Direction
        {
            EAST,
            NORTH,
            WEST,
            SOUTH
        }

        public string input = "368078";
    }
}