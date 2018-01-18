using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using AdventOfCode2017;
using AdventOfCode2017.Challenges;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day18Test
    {

        [TestMethod]
        public void Day18Part01() {
            var day = new Day18();
            string input = @"set a 1
add a 2
mul a a
mod a 5
snd a
set a 0
rcv a
jgz a -1
set a 1
jgz a -2";
            day.Part01(input).Should().Be("4");
        }
    }
}
