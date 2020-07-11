using BlakeIshoyAlgorithms.CodingSiteProblems.LeetCodeProblems;
using BlakeIshoyAlgorithms.Data_Structures;
using BlakeIshoyAlgorithms.MathAlgorithms;
using System;
using System.Linq;

namespace BlakeIshoyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var output = new Problem1476RectangleMatrix().Execute();
            var output = new BinaryTree(27);
            output.AddNode(14);
            var find = output.Search(14);

            Console.WriteLine(output);
        }

        
    }
}
