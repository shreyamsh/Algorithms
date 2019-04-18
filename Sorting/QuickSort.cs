using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        /* Take the last element as pivot, place the pivot at its correct position in sorted array.
            Place smaller elements (less than pivot) to left of pivot and greater elements to right of pivot.
         */
        public static int Partition(int []arr, int low, int high) {
            int pivot = arr[high];

            // Index of smaller element
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    //Swap(arr[i], arr[j]);
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            //Swap(arr[i + 1], arr[high]);
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        //public static void Swap (int first, int second)
        //{
        //    int tmp = first;
        //    first = second;
        //    second = tmp;
        //}

        /*Time Complexity: Woest Case (Rare): O(n^2), Average Case:L O(nLogn)*/
        public static void QuickSortImplementation(int []arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                // Recursively sort elements before and after partition
                QuickSortImplementation(arr, low, partitionIndex - 1);
                QuickSortImplementation(arr, partitionIndex + 1, high);
            }
        }

        // A utility function to print array of size n 
        static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        // Driver program 
        public static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            PrintArray(arr, n);
            QuickSortImplementation(arr, 0, n - 1);
            Console.WriteLine("Sorted Array is:");
            PrintArray(arr, n);
        }
    }
}
