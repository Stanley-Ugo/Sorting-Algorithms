using SortingAlgorithms;
using System;

namespace SortingAlgorithmsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestInsertionSort();
            TestMergeSort();
            
        }

        private static void TestInsertionSort()
        {
            Console.WriteLine("Pleadse Enter 10 Nunmbers");

            int numbers1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter To Sort");

            int[] numbersArray = { numbers1, numbers2, numbers3, numbers4, numbers5, numbers6, numbers7, numbers8, numbers9, numbers10 };

            numbersArray.DoInsertionSort();

            foreach (int number in numbersArray)
                Console.Write(number + " ");
        }

        private static void TestMergeSort()
        {
            Console.WriteLine("Pleadse Enter 10 Nunmbers");

            int numbers1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pleadse Insert Another Nunmbers");

            int numbers10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter To Sort");

            int[] numbersArray = { numbers1, numbers2, numbers3, numbers4, numbers5, numbers6, numbers7, numbers8, numbers9, numbers10 };

            numbersArray.DoMergeSort();

            foreach (int number in numbersArray)
                Console.Write(number + " ");
        }
    }
}
