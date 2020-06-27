using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures
{
    public class BinaryTree
    {
        public List<BinaryNode> Tree { get; set; }
        public BinaryNode Head { get; set; }

        public BinaryTree(BinaryNode root)
        {
            this.Head = root;
        }

        public List<int> GetLeaves(List<int> leaves, BinaryNode node)
        {
            if (node == null) return leaves;

            if (node.LeftChild == null && node.RightChild == null)
            {
                leaves.Add(node.Value);
            }
            if (node.LeftChild != null)
            {
                return GetLeaves(leaves, node.LeftChild);
            }
            if (node.RightChild != null)
            {
                return GetLeaves(leaves, node.RightChild);
            }
            return leaves;
        }
    }
}
