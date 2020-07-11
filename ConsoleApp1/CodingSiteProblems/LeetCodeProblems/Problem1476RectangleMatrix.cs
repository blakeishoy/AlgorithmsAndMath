using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.CodingSiteProblems.LeetCodeProblems
{
    public class Problem1476RectangleMatrix : ICodingProblem
    {
        //Expected 5
        public bool Execute()
        {
            var matrix = new int[][] {
                new int[] {1,2,1},
                new int[] {4,3,4},
                new int[] {3,2,1},
                new int[] {1,1,1}
            };
            var recQuer = new SubrectangleQueries(matrix);
            recQuer.UpdateSubrectangle(0, 0, 3, 2, 5);
            return recQuer.GetValue(0, 2) == 5;
        }

        public class SubrectangleQueries
        {

            public int[][] Rectangle { get; set; }

            public SubrectangleQueries(int[][] rectangle)
            {
                this.Rectangle = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                foreach (var entry in this.Rectangle)
                {
                    foreach (var element in entry)
                    {
                        var i = 0;
                        var j = 0;
                        if (i >= row1 && i >= col1)
                        {
                            if (j < row2 && j < col2)
                            {
                                this.Rectangle[i][j] = newValue;
                            }
                        }
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return this.Rectangle[row][col];
            }
        }
    }
}
