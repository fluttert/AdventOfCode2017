using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day16Test
    {
        [TestMethod]
        public void Day16Part01Spin() {
            var day = new Day16();
            day.ProgramLength = 5;

            day.Part01("s1").Should().Be("eabcd");
            day.Part01("x0/4").Should().Be("ebcda");
            day.Part01("pa/e").Should().Be("ebcda");

            day.Part01("s1,x3/4,pe/b").Should().Be("baedc");
        }
    }
}
