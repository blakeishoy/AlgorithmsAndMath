using System;
using System.Collections.Generic;
using System.Text;
using BlakeIshoyAlgorithms.CodingSiteProblems.LeetCodeProblems;
using NUnit.Framework;

namespace AlgorithmUnitTests
{
    public class LeetCodeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1282()
        {
            Assert.IsTrue(new Problem1282PeopleGroup().Execute());
        }

        //[Test]
        //public void Test1476()
        //{
        //    Assert.IsTrue(new Problem1476RectangleMatrix().Execute());
        //}

        [Test]
        public void Test46()
        {
            Assert.IsTrue(new Problem46Permutations().Execute());
        }
    }
}
