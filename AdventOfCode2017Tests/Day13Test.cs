using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day13Test
    {
        [TestMethod]
        public void Day13Part01() {
            var day = new Day13();
            var input = @"0: 3
1: 2
4: 4
6: 4";
            day.Part01(input).Should().Be("24");
        }
    }
}
