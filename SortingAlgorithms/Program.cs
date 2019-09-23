using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            SelectionSort.Sort(arr);
            Console.WriteLine("Selection sorted array");
            PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
