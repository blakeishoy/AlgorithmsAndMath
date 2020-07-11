using BlakeIshoyAlgorithms.Data_Structures.Sorting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmUnitTests
{
    public class SortingTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestBubbleSort()
        {
            var beforeSort = new int[] { 14, 33, 27, 35, 10, 19 };
            var afterSort = beforeSort;
            Array.Sort(afterSort);
            Assert.IsTrue(afterSort.SequenceEqual(Sort.BubbleSort(beforeSort)));
        }

        [Test]
        public void TestInsertionSort()
        {
            var beforeSort = new int[] { 14, 33, 27, 35, 10, 19 };
            var afterSort = beforeSort;
            Array.Sort(afterSort);
            Assert.IsTrue(afterSort.SequenceEqual(Sort.InsertionSort(beforeSort)));
        }

        [Test]
        public void TestSelectionSort()
        {
            var beforeSort = new int[] { 14, 33, 27, 35, 10, 19 };
            var afterSort = beforeSort;
            Array.Sort(afterSort);
            Assert.IsTrue(afterSort.SequenceEqual(Sort.SelectionSort(beforeSort)));
        }
    }
}
