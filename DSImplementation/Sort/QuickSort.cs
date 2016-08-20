using System;
using DSImplementation;

namespace DSImplementation.Sort
{
    public class QuickSort
    {
        public int[] Sort(int[] input)
        {
            if (input == null)
                throw new InvalidOperationException("Array is null.");
            else
            {
                return Sort(input, SortOrderType.Asc);
            }
        }

        public int[] Sort(int[] input, SortOrderType orderType)
        {
            if (input == null)
                throw new InvalidOperationException("Array is null.");
            else
            {
                int len = input.Length - 1;
                return QS(input, 0, len, orderType);
            }
        }

        private int[] QS(int[] input, int low, int high, SortOrderType orderType)
        {
            if (low < high)
            {
                int pivot = Partition(input, low, high, orderType);

                QS(input, low, pivot - 1, orderType);
                QS(input, pivot + 1, high, orderType);
            }

            return input;
        }

        private int Partition(int[] input, int low, int high, SortOrderType orderType)
        {
            int pivot = input[high];
            int i = low;
            int temp = int.MinValue;

            for (int j = low; j < high; j++)
            {
                if (orderType == SortOrderType.Desc)
                {
                    if (pivot <= input[j])
                    {
                        temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                        i += 1;
                    }
                }
                else
                {
                    if (pivot >= input[j])
                    {
                        temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                        i += 1;
                    }
                }
            }

            temp = input[high];
            input[high] = input[i];
            input[i] = temp;

            return i;
        }
    }
}
