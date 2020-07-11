using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlakeIshoyAlgorithms.MathAlgorithms;
using BlakeIshoyAlgorithms.Utility;

namespace BlakeIshoyAlgorithms.CodingSiteProblems.LeetCodeProblems
{
    /// <summary>
    /// Given a collection of distinct integers, return all possible permutations.
    /// Input: [1,2,3]
    /// Output: [ [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], [3,2,1] ]
    /// </summary>
    public class Problem46Permutations : ICodingProblem
    {
        public bool Execute()
        {
            var input = new int[] { 1, 2, 3 };
            var result = PermuteRandomly(input);
            var compare = new List<List<int>>() {
                new List<int>() {1,2,3},
                new List<int>() {1,3,2},
                new List<int>() {2,1,3},
                new List<int>() {2,3,1},
                new List<int>() {3,1,3},
                new List<int>() {3,2,1}
            };
            return ListOfListComparer.Compare(result, compare);
        }

        public static IList<IList<int>> PermuteRandomly(int[] nums)
        {
            var times = MathTools.PermutationCalc(nums.Length, nums.ToList().Distinct().Count());
            var result = new List<IList<int>>();
            while (result.Count != times)
            {
                var rnd = new Random();
                var newList = nums.OrderBy(x => rnd.Next()).ToList();
                var shouldAdd = true;
                if (result.Count > 0)
                {
                    foreach (var list in result)
                    {
                        if (newList.SequenceEqual(list))
                        {
                            shouldAdd = false;
                        }
                    }
                    if (shouldAdd) { result.Add(newList); }
                }
                else
                {
                    result.Add(newList);
                }
            }
            return result;
        }

        public static List<List<int>> PermuteProcedurally(int[] nums)
        {
            var times = MathTools.PermutationCalc(nums.Length, nums.ToList().Distinct().Count());
            var result = new List<List<int>>();
            for (int i = 0; i < times; i++)
            {
                var sample = new int[] { };
                //sample
            }

            return result;
        }
    }
}
