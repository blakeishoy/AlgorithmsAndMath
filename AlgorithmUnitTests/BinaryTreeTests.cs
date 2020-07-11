using BlakeIshoyAlgorithms.Data_Structures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmUnitTests
{
    public class BinaryTreeTests
    {
        public BinaryTree Tree { get; set; }
        [SetUp]
        public void Setup()
        {
            this.Tree = new BinaryTree(27);
            this.Tree.AddNode(14);
            this.Tree.AddNode(35);
            this.Tree.AddNode(42);
            this.Tree.AddNode(10);
            this.Tree.AddNode(19);
            this.Tree.AddNode(31);
        }

        [Test]
        public void VerifyOrganization()
        {
            var node27 = this.Tree.Search(27);
            var node14 = this.Tree.Search(14);
            var node35 = this.Tree.Search(35);
            var node10 = this.Tree.Search(10);
            var node19 = this.Tree.Search(19);
            var node31 = this.Tree.Search(31);
            var node42 = this.Tree.Search(42);
            
            var verify10 = node10.Value == 10 && node10 != null && node10.LeftChild == null && node10.RightChild == null;
            var verify19 = node19.Value == 19 && node19 != null && node19.LeftChild == null && node19.RightChild == null;
            var verify14 = node14.Value == 14 && node14 != null && node14.LeftChild == node10 && node14.RightChild == node19;
            var verify27 = node27.Value == 27 && node27 != null && node27.LeftChild == node14 && node27.RightChild == node35;
            var verify35 = node35.Value == 35 && node35 != null && node35.LeftChild == node31 && node35.RightChild == node42;
            var verify31 = node31.Value == 31 && node31 != null && node31.LeftChild == null && node31.RightChild == null;
            var verify42 = node42.Value == 42 && node42 != null && node42.LeftChild == null && node42.RightChild == null;

            var totalVerification = verify10 && verify19 && verify14 && verify27 && verify35 && verify31 && verify42;
            Assert.IsTrue(totalVerification);
        }

        [Test]
        public void InOrderTraversal()
        {
            var inOrderList = this.Tree.InOrderTraversal();
            var correctOrder = new List<int>() { 10, 14, 19, 27, 31, 35, 42 };
            var sameOrder = inOrderList.SequenceEqual(correctOrder);

            Assert.IsTrue(sameOrder);
        }

        [Test]
        public void PreOrderTraversal()
        {
            var inOrderList = this.Tree.PreOrderTraversal();
            var correctOrder = new List<int>() { 27, 14, 10, 19, 35, 31, 42 };
            var sameOrder = inOrderList.SequenceEqual(correctOrder);

            Assert.IsTrue(sameOrder);
        }

        [Test]
        public void PostOrderTraversal()
        {
            var inOrderList = this.Tree.PostOrderTraversal();
            var correctOrder = new List<int>() { 10, 19, 14, 31, 42, 35, 27, };
            var sameOrder = inOrderList.SequenceEqual(correctOrder);

            Assert.IsTrue(sameOrder);
        }
    }
}