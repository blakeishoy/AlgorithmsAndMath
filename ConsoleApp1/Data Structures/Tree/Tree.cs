using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures
{
    public class Tree
    {
        public List<Node> Nodes { get; set; }
        public Node Head { get; set; }

        public Tree(Node root)
        {
            this.Head = root;
        }

        public Tree(int value)
        {
            this.Head = new Node(value);
        }

        //nums = [1,2,3]
        public void IntegrateArray(int[] nums)
        {
            var currentNode = this.Head;
            foreach (var item in nums)
            {

            }
        }
    }
}
