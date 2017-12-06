﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Challenges;

namespace AdventOfCode2017Tests
{
    [TestClass]
    public class Day06Test
    {
        [TestMethod]
        public void Day06Part01(){
            var day = new Day06();
            day.Part01("0 2 7 0").Should().Be("5");
        }
    }
}
