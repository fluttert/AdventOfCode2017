using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Challenges;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day09Test
    {
        [TestMethod]
        public void Day09Part01() {
            var day = new Day09();
            day.Part01("{}").Should().Be("1");
            day.Part01("{{{}}}").Should().Be("6");
            day.Part01("{{},{}}").Should().Be("5");
            day.Part01("{{{},{},{{}}}}").Should().Be("16");
            day.Part01("{<a>,<a>,<a>,<a>}").Should().Be("1");
            day.Part01("{{<ab>},{<ab>},{<ab>},{<ab>}}").Should().Be("9");
            day.Part01("{{<!!>},{<!!>},{<!!>},{<!!>}}").Should().Be("9");
            day.Part01("{{<a!>},{<a!>},{<a!>},{<ab>}}").Should().Be("3");
        }
    }
}
