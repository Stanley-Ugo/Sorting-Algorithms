﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSorter
    {
        //The Do Merge method
        public static void DoMergeSort(this int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);

            for (int i = 0; i < sortedNumbers.Length; i++)
                numbers[i] = sortedNumbers[i];
        }

        //The Merge Sort Function
        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers; // Base Case

            var left = new List<int>();
            var right = new List<int>();
            Divide(numbers, left, right);

            left = MergeSortList(left);
            right = MergeSortList(right);

            return Merge(left, right);
        }

        //The MergeSortList function
        private static List<int> MergeSortList(List<int> list)
        {
            return MergeSort(list.ToArray()).ToList();
        }

        //The Divide Method
        private static void Divide(int[] numbers, List<int> left, List<int> right)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i.IsOdd())
                    left.Add(numbers[i]);
                else
                    right.Add(numbers[i]);
            }
        }

        //The Merge Function
        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (NotEmpty(left) && NotEmpty(right))
                MoveSmallerValuesInLeftOrRightToResult(left, right, result);

            MoveRemaininValuesFromSourceToResult(left, result);

            MoveRemaininValuesFromSourceToResult(right, result);

            return result.ToArray();
        }

        //Adding the NotEmpty MEthod
        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        //The function moves smaller values from left/right to the result var
        private static void MoveSmallerValuesInLeftOrRightToResult(List<int> left, List<int> right, List<int> result)
        {
            if (left.First() <= right.First())
                MoveValueFromSourceToResult(left, result);
            else
                MoveValueFromSourceToResult(right, result);
        }

        //Moving the values form source to result
        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }

        private static void MoveRemaininValuesFromSourceToResult(List<int> left, List<int> result)
        {
            while (NotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }
        }
    }
}
