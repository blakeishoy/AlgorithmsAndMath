using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures
{
    public class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode LeftChild { get; set; }
        public BinaryNode RightChild { get; set; }

        public BinaryNode(int value)
        {
            this.Value = value;
            this.LeftChild = null;
            this.RightChild = null;
        }

    }
}
