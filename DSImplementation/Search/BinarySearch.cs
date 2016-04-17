using System;
using DSImplementation.Sort;

namespace DSImplementation.Search
{
    public class BinarySearch
    {
        public int Search(int key, int[] input)
        {
            SortInputData(input);
            PrintSortedData(input);
            //return SearchData(key, input);
            return SearchRecursive(key, 0, input.Length, input);
        }

        private void PrintSortedData(int[] data)
        {
            Console.Write("SortedData : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);

                if (i < data.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        private int SearchData(int key, int[] input)
        {
            var keyIndex = -1;
            var min = 0;
            var max = input.Length - 1;

            var mid = -1;

            while (min < max)
            {
                mid = (max + min) / 2;

                if (input[mid] < key)
                {
                    min = mid;
                }
                else if (input[mid] > key)
                {
                    max = mid;
                }
                else
                {
                    keyIndex = mid;
                    break;
                }
            }

            return keyIndex;
        }

        private int SearchRecursive(int key, int left, int right, int[] input)
        {
            var keyIndex = -1;

            var mid = (left + (right - 1)) / 2;

            if (input[mid] == key)
            {
                return mid;
            }
            else
            {
                if (mid < key)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }

            if (right > left)
            {
                keyIndex = SearchRecursive(key, left, right, input);
            }
            else
            {
                keyIndex = -1;
            }

            return keyIndex;
        }

        private int[] SortInputData(int[] input)
        {
            SelectionSort selection = new SelectionSort();
            return selection.Sort(input);
        }
    }
}
