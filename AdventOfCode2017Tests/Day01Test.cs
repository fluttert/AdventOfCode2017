using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day01Test
    {
        [TestMethod]
        public void Day01Part01()
        {
            var day01 = new Day01();

            day01.Part01("1122").Should().Be("3");
            day01.Part01("1111").Should().Be("4");
            day01.Part01("1234").Should().Be("0");
            day01.Part01("91212129").Should().Be("9");
        }

        [TestMethod]
        public void Day01Part02()
        {
            var day01 = new Day01();

            day01.Part02("1212").Should().Be("6");
            day01.Part02("1221").Should().Be("0");
            day01.Part02("123425").Should().Be("4");
            day01.Part02("123123").Should().Be("12");
            day01.Part02("12131415").Should().Be("4");
        }
    }
}