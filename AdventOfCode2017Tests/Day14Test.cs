using AdventOfCode2017.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day14Test
    {
        [TestMethod]
        public void Day14Part01()
        {
            var day = new Day14();
            var grid = day.GenerateGrid("flqrgnkx");
            day.Part01("flqrgnkx").Should().Be("8108");
        }
    }
}