using System;

namespace SortingAlgorithms
{
    public static class InsertionSorter
    {
        public static void DoInsertionSort(this int[] numbers)
        {
            for (int i = 1; i < numbers.Length; ++i)
            {
                for (int j = i; j > 0 && numbers[j -1] > numbers[j]; j--)
                {
                    numbers.SwappValuesAtIndices(j, j - 1);
                }
            }
        }

        public static void SwappValuesAtIndices(this int[] numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
