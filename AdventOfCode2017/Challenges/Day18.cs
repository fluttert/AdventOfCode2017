using AdventOfCode2017.Interfaces;
using System;
using System.Collections.Generic;

namespace AdventOfCode2017.Challenges
{
    public class Day18 : IChallengeDay
    {
        public string Part01(string input)
        {
            string[] instructions = input.Trim().Split('\n');
            var registers = new Dictionary<string, int>();
            int frequency = 0;

            int nextInstruction = 0;
            int result = 0;
            while (nextInstruction < instructions.Length)
            {
                int increment = 1;

                string[] parts = instructions[nextInstruction].Trim().Split(' ');
                if (parts[1][0] >= 'a' && parts[1][0] <= 'z' && !registers.ContainsKey(parts[1])) { registers.Add(parts[1], 0); }
                if (parts.Length > 2 && parts[2][0] >= 'a' && parts[2][0] <= 'z' && !registers.ContainsKey(parts[2])) { registers.Add(parts[2], 0); }
                switch (parts[0])
                {
                    case "snd":
                        frequency = registers[parts[1]];
                        break;

                    case "set":
                        registers[parts[1]] = (parts[2][0] >= 'a' && parts[2][0] <= 'z' ? registers[parts[2]] : int.Parse(parts[2]));
                        break;

                    case "add":
                        registers[parts[1]] += (parts[2][0] >= 'a' && parts[2][0] <= 'z' ? registers[parts[2]] : int.Parse(parts[2])); ;
                        break;

                    case "mul":
                        registers[parts[1]] *= (parts[2][0] >= 'a' && parts[2][0] <= 'z' ? registers[parts[2]] : int.Parse(parts[2])); ;
                        break;

                    case "mod":
                        registers[parts[1]] %= (parts[2][0] >= 'a' && parts[2][0] <= 'z' ? registers[parts[2]] : int.Parse(parts[2])); ;
                        break;

                    case "rcv":
                        result = registers[parts[1]] == 0 ? 0 : frequency;
                        break;

                    case "jgz":

                        if (registers[parts[1]] > 0)
                        {
                            int jump = (parts[2][0] >= 'a' && parts[2][0] <= 'z' ? registers[parts[2]] : int.Parse(parts[2])); ;
                            if (jump < 0) { increment = jump; }
                            else { increment = jump - 1; }
                        }
                        break;

                    default:
                        break;
                }
                if (result != 0) { break; }
                nextInstruction += increment;
            }

            return result.ToString(); ;
        }

        public string Part02(string input)
        {
            throw new NotImplementedException();
        }

        public string input = @"set i 31
set a 1
mul p 17
jgz p p
mul a 2
add i -1
jgz i -2
add a -1
set i 127
set p 680
mul p 8505
mod p a
mul p 129749
add p 12345
mod p a
set b p
mod b 10000
snd b
add i -1
jgz i -9
jgz a 3
rcv b
jgz b -1
set f 0
set i 126
rcv a
rcv b
set p a
mul p -1
add p b
jgz p 4
snd a
set a b
jgz 1 3
snd b
set f 1
add i -1
jgz i -11
snd a
jgz f -16
jgz a -19";
    }
}