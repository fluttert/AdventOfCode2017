using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Challenges;
using FluentAssertions;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day02Test
    {
        [TestMethod]
        public void Day02Part01() {
            var day02 = new Day02();
            var input = @"5 1 9 5
7 5 3
2 4 6 8";
            day02.Part01(input).Should().Be("18");

        }

        [TestMethod]
        public void Day02Part02()
        {
            var day02 = new Day02();
            var input = @"5 9 2 8
9 4 7 3
3 8 6 5";
            day02.Part02(input).Should().Be("9");

        }
    }
}
