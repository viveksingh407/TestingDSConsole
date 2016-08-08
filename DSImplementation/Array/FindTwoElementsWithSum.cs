using System;
using DSImplementation.Sort;

namespace DSImplementation.Array
{
    public class FindTwoElementsWithSum
    {
        public void FindSum()
        {
            Console.Write("Test case count:");
            var testCaseCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCaseCount; i++)
            {
                GetArrayCountAndSum();
            }
        }

        private void GetArrayCountAndSum()
        {
            Console.Write("Sum:");
            var sum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Array length:");
            var arrLength = Convert.ToInt32(Console.ReadLine());

            var arr = GetArray(arrLength);

            Print(arr);

            Sum(arr, sum);
        }

        private int[] GetArray(int arrLength)
        {
            var arr = new int[arrLength];

            Random rnd = new Random();

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = rnd.Next(10);
            }

            return arr;
        }

        /// <summary>
        /// O(nlogn) + O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        private void Sum(int[] arr, int sum)
        {
            bool isSum = false;
            int left = 0, right = arr.Length - 1;

            SelectionSort sort = new SelectionSort();
            arr = sort.Sort(arr);

            Print(arr);

            while (left <= right)
            {
                if (arr[left] + arr[right] == sum)
                {
                    isSum = true;
                    break;
                }
                else if (arr[left] + arr[right] > sum)
                {
                    right -= 1;
                }
                else if (arr[left] + arr[right] < sum)
                {
                    left += 1;
                }
            }

            var sumPresent = isSum ? "Yes" : "No";
            Console.WriteLine(sumPresent);
        }

        /// <summary>
        /// O(N^2)
        /// </summary>
        /// <param name="arr"></param>
        //private void Sum(int[] arr, int sum)
        //{
        //    bool isSum = false;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i; j < arr.Length; j++)
        //        {
        //            if (arr[i] + arr[j] == sum)
        //            {
        //                isSum = true;
        //                break;
        //            }
        //        }
        //    }

        //    var sumPresent = isSum ? "Yes" : "No";
        //    Console.WriteLine(sumPresent);
        //}

        private void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
