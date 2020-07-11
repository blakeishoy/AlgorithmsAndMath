using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures
{
    public class BinaryTree
    {
        public BinaryNode Head { get; set; }

        public BinaryTree(int root)
        {
            this.Head = new BinaryNode(root);
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

        public void AddNode(int newValue)
        {
            var newNode = new BinaryNode(newValue);
            var current = this.Head;
            var positionFound = false;
            while (!positionFound)
            {
                
                var parent = current;
                if (newNode.Value < parent.Value)
                {
                    current = current.LeftChild;
                    if (current == null)
                    {
                        parent.LeftChild = newNode;
                        positionFound = true;
                    }
                }
                else
                {
                    current = current.RightChild;
                    if (current == null)
                    {
                        parent.RightChild = newNode;
                        positionFound = true;
                    }
                }
            }
        }

        public BinaryNode Search(int value)
        {
            var current = this.Head;
            while (current.Value != value)
            {
                if (current != null)
                {
                    if (current.Value > value)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        current = current.RightChild;
                    }
                }
                else
                {
                    return null;
                }
            }
            return current;
        }

        /// <summary>
        /// Outputs a List of Nodes in the Tree in ascending order
        /// </summary>
        /// <returns></returns>
        public List<int> InOrderTraversal()
        {
            var returnList = new List<int>();

            returnList = this.RecursiveInOrderTraverse(returnList, this.Head);

            return returnList;
        }

        private List<int> RecursiveInOrderTraverse(List<int> nodeList, BinaryNode currentNode)
        {
            if (currentNode != null)
            {
                nodeList = RecursiveInOrderTraverse(nodeList, currentNode.LeftChild);
                nodeList.Add(currentNode.Value);
                return RecursiveInOrderTraverse(nodeList, currentNode.RightChild);
            }
            else
            {
                return nodeList;
            }
        }

        public List<int> PreOrderTraversal()
        {
            var returnList = new List<int>();

            returnList = this.RecursivePreOrderTraverse(returnList, this.Head);

            return returnList;
        }

        private List<int> RecursivePreOrderTraverse(List<int> nodeList, BinaryNode currentNode)
        {
            if (currentNode != null)
            {
                nodeList.Add(currentNode.Value);
                nodeList = RecursivePreOrderTraverse(nodeList, currentNode.LeftChild);
                return RecursivePreOrderTraverse(nodeList, currentNode.RightChild);
            }
            else
            {
                return nodeList;
            }
        }

        public List<int> PostOrderTraversal()
        {
            var returnList = new List<int>();

            returnList = this.RecursivePostOrderTraverse(returnList, this.Head);

            return returnList;
        }

        private List<int> RecursivePostOrderTraverse(List<int> nodeList, BinaryNode currentNode)
        {
            if (currentNode != null)
            {
                nodeList = RecursivePostOrderTraverse(nodeList, currentNode.LeftChild);
                nodeList = RecursivePostOrderTraverse(nodeList, currentNode.RightChild);
                nodeList.Add(currentNode.Value);
                return nodeList;
            }
            else
            {
                return nodeList;
            }
        }

        public BinaryNode GetLowestNode()
        {
            var current = this.Head;
            var lowestFound = false;
            while (!lowestFound)
            {
                if (current.LeftChild != null)
                {
                    current = current.LeftChild;
                }
                else
                {
                    lowestFound = true;
                }
            }
            return current;
        }
    }
}
