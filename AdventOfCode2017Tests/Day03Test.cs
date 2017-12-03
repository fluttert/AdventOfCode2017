using AdventOfCode2017.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day03Test
    {
        [TestMethod]
        public void Day03Part01()
        {
            var day03 = new Day03();
            day03.Part01("1").Should().Be("0");
            day03.Part01("2").Should().Be("1");
            day03.Part01("9").Should().Be("2");
            day03.Part01("25").Should().Be("4");
            day03.Part01("12").Should().Be("3");
            day03.Part01("23").Should().Be("2");
            day03.Part01("36").Should().Be("5");
            day03.Part01("37").Should().Be("6");
            day03.Part01("26").Should().Be("5");
            day03.Part01("43").Should().Be("6");
            day03.Part01("38").Should().Be("5");
            day03.Part01("1024").Should().Be("31");
        }

        [TestMethod]
        public void Day03Part02() {
            var day03 = new Day03();
            day03.Part02("1").Should().Be("2");
            day03.Part02("58").Should().Be("59");
            day03.Part02("59").Should().Be("122");
        }
    }
}