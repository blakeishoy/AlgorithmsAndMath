using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.Data_Structures.Sorting
{
    public static class Sort
    {
        /// <summary>
        /// Time complexity of O(n^2)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            var indexToSwap = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i+1 < array.Length)
                {
                    if (array[i] > array[i + 1])
                    {
                        indexToSwap = i;
                        break;
                    }
                }
            }

            if (indexToSwap != -1)
            {
                var tempStore = array[indexToSwap + 1];
                array[indexToSwap + 1] = array[indexToSwap];
                array[indexToSwap] = tempStore;
                array = BubbleSort(array);
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var insertValue = array[i];
                var openPosition = i;

                while (openPosition > 0 && array[openPosition-1] > insertValue)
                {
                    array[openPosition] = array[openPosition - 1];
                    openPosition--;
                }

                array[openPosition] = insertValue;
            }
            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var minimum = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minimum])
                    {
                        minimum = j;
                    }
                }
                if (minimum != i)
                {
                    var tempStore = array[i];
                    array[i] = array[minimum];
                    array[minimum] = tempStore;
                }
            }

            return array;
        }
    }
}
