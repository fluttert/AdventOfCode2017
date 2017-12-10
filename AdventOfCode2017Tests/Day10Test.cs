using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day10Test
    {
        [TestMethod]
        public void Day10Part01()
        {
            var day = new Day10();
            day.ListLength = 5;
            day.Part01("3, 4, 1, 5").Should().Be("12");
        }
    }
}