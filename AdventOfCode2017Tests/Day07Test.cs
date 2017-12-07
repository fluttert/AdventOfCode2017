using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Challenges;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day07Test
    {
        [TestMethod]
        public void Day07Part01() {
            var day = new Day07();
            var input = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
            day.Part01(input).Should().Be("tknk");
        }
    }
}
