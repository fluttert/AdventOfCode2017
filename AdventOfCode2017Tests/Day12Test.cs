using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day12Test
    {
        [TestMethod]
        public void Day12Part01() {
            var day = new Day12();
            var input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5";
            day.Part01(input).Should().Be("6");
        }
    }
}
