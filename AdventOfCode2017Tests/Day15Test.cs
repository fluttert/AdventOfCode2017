using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day15Test
    {
        //[TestMethod] // disabled long test
        public void Day15Part01() {
            var day = new Day15();
            day.Part01("65 8921").Should().Be("588");
        }

        //[TestMethod] // disabled long test
        public void Day15Part02()
        {
            var day = new Day15();
            day.Part02("65 8921").Should().Be("309");
        }

    }
}
