using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day04Test
    {
        [TestMethod]
        public void Day04Part01() {
            var day = new Day04();
            day.Part01("aa bb cc dd ee").Should().Be("1");
            day.Part01("aa bb cc dd aa").Should().Be("0");
            day.Part01("aa bb cc dd aaa").Should().Be("1");
            day.Part01("aa aa").Should().Be("0");
            day.Part01(@"aa aa
bb bb
aa bb").Should().Be("1");


        }

        [TestMethod]
        public void Day04Part02()
        {
            var day = new Day04();
            day.Part02("aa bb cc dd ee").Should().Be("1");
            day.Part02("abcde xyz ecdab").Should().Be("0");



        }
    }
}
