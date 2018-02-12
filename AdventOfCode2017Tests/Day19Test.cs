using AdventOfCode2017.Challenges;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day19Test
    {
        [TestMethod]
        public void Day19Part01() {
            string input = @"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+ 

";
            var day = new Day19();
            day.Part01(input).Should().Be("ABCDEF");
        }

        [TestMethod]
        public void Day19Part02()
        {
            string input = @"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+ 

";
            var day = new Day19();
            day.Part02(input).Should().Be("38");
        }
    }
}
