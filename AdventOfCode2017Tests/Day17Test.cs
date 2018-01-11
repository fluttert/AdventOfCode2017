using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day17Test
    {
        [TestMethod]
        public void Day17Part01()
        {
            var day = new Day17();
            day.Part01("3").Should().Be("638");
        }
    }
}
