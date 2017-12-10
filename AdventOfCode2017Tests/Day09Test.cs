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

        [TestMethod]
        public void Day09Part02() {
            var day = new Day09();
            day.Part02("<>").Should().Be("0");
            day.Part02("<random characters>").Should().Be("17");
            day.Part02("<<<<>").Should().Be("3");
            day.Part02("<{!>}>").Should().Be("2");
            day.Part02("<!!>").Should().Be("0");
            day.Part02("<!!!>>").Should().Be("0");
            day.Part02("<{oi!a,<{i<a>").Should().Be("9");
        }
    }
}
