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

        [TestMethod]
        public void Day10Part02()
        {
            var day = new Day10();
            day.Part02("").Should().Be("a2582a3a0e66e6e86e3812dcb672a272");

            day.Part02("1,2,3").Should().Be("3efbe78a8d82f29979031a4aa0b16a9d");
            
            day.Part02("AoC 2017").Should().Be("33efeb34ea91902bb2f59c9920caa6cd");
            
            day.Part02("1,2,4").Should().Be("63960835bcdc130f0b66d7ff4f6a5a8e");
        }
    }
}