using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSorter
    {
        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers; // Base Case

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return MergeSort(left, right);
        }
    }
}
