using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using AdventOfCode2017.Challenges;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day11Test
    {
        [TestMethod]
        [DataRow("ne,ne,ne", "3")]
        [DataRow("ne,ne,sw,sw", "0")]
        [DataRow("ne,ne,s,s", "2")]
        [DataRow("se,sw,se,sw,sw", "3")]
        public void Day11Part01(string input, string expectedResult) {
            var day = new Day11();
            day.Part01(input).Should().Be(expectedResult);
        }
    }
}
