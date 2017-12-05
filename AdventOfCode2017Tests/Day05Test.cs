using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day05Test
    {
        [TestMethod]
        public void Day05Part01()
        {
            var day = new Day05();
            day.Part01(@"0
3
0
1
-3").Should().Be("5");
        }
    }
}