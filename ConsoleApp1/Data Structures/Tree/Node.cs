using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; }

        public Node(int val)
        {
            this.Value = val;
        }
    }
}
