using AdventOfCode2017.Interfaces;
using System;
using System.Collections.Generic;

namespace AdventOfCode2017.Challenges
{
    public class Day18 : IChallengeDay
    {
        public string Part01(string input)
        {
            string[] instructions = input.Trim().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var register = new Dictionary<char, long>();
            long lastFrequency = 0, nextInstruction = 0;
            bool exit = false;

            string registerKeys = "abcdefghijklmnopqrstuvwxyz";
            foreach (char registerKey in registerKeys) { register.Add(registerKey, 0); }

            // my first local function!
            long GetByParsingOrRegister(string part)
            {
                long result = 0;
                if (part.Length < 1) { throw new ArgumentException($"Empty argument"); }
                if (part[0] >= 'a' && part[0] <= 'z') { result = register[part[0]]; }
                else { result = Int64.Parse(part); }
                return result;
            }

            while (!exit && nextInstruction < instructions.Length)
            {
                long increment = 1;
                string[] parts = instructions[nextInstruction].Trim().Split(' ');

                switch (parts[0])
                {
                    case "snd":
                        lastFrequency = GetByParsingOrRegister(parts[1]);
                        break;

                    case "set":
                        register[parts[1][0]] = GetByParsingOrRegister(parts[2]);
                        break;

                    case "add":
                        register[parts[1][0]] += GetByParsingOrRegister(parts[2]);
                        break;

                    case "mul":
                        register[parts[1][0]] *= GetByParsingOrRegister(parts[2]);
                        break;

                    case "mod":
                        register[parts[1][0]] %= GetByParsingOrRegister(parts[2]);
                        break;

                    case "rcv":
                        long res = GetByParsingOrRegister(parts[1]);
                        if (res != 0) { exit = true; }
                        break;

                    case "jgz":
                        long valX = GetByParsingOrRegister(parts[1]);
                        if (valX > 0)
                        {
                            long valY = GetByParsingOrRegister(parts[2]);
                            increment = valY;
                        }
                        break;

                    default:
                        break;
                }

                nextInstruction += increment;
            }
            return lastFrequency.ToString(); ;
        }

        public string Part02(string input)
        {
            string[] instructions = input.Trim().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var register = new Dictionary<char, long>();
            long sendValue = 0, nextInstruction = 0;
            bool exit = false;

            string registerKeys = "abcdefghijklmnopqrstuvwxyz";
            foreach (char registerKey in registerKeys) { register.Add(registerKey, 0); }

            // my first local function!
            long GetByParsingOrRegister(string part)
            {
                long result = 0;
                if (part.Length < 1) { throw new ArgumentException($"Empty argument"); }
                if (part[0] >= 'a' && part[0] <= 'z') { result = register[part[0]]; }
                else { result = Int64.Parse(part); }
                return result;
            }

            while (!exit && nextInstruction < instructions.Length)
            {
                long increment = 1;
                string[] parts = instructions[nextInstruction].Trim().Split(' ');

                switch (parts[0])
                {
                    case "snd":
                        sendValue++;
                        break;

                    case "set":
                        register[parts[1][0]] = GetByParsingOrRegister(parts[2]);
                        break;

                    case "add":
                        register[parts[1][0]] += GetByParsingOrRegister(parts[2]);
                        break;

                    case "mul":
                        register[parts[1][0]] *= GetByParsingOrRegister(parts[2]);
                        break;

                    case "mod":
                        register[parts[1][0]] %= GetByParsingOrRegister(parts[2]);
                        break;

                    case "rcv":
                        long res = GetByParsingOrRegister(parts[1]);
                        if (res != 0) { exit = true; }
                        break;

                    case "jgz":
                        long valX = GetByParsingOrRegister(parts[1]);
                        if (valX > 0)
                        {
                            long valY = GetByParsingOrRegister(parts[2]);
                            increment = valY;
                        }
                        break;

                    default:
                        break;
                }

                nextInstruction += increment;
            }
            return sendValue.ToString(); ;
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