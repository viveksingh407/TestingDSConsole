using System;

namespace DSImplementation.Sort
{
    public class CountingSort
    {
        public int[] Sort(int[] input, int range)
        {
            if (input == null)
                throw new InvalidOperationException("Array is null.");
            else
            {
                return Sort(input, range, SortOrderType.Asc);
            }
        }

        public int[] Sort(int[] input, int range, SortOrderType orderType)
        {
            if (input == null)
                throw new InvalidOperationException("Array is null.");
            else
            {
                int[] output = new int[input.Length];
                int[] rangeArr = new int[range];

                for (int i = 0; i < input.Length; i++)
                {
                    rangeArr[input[i]] += 1;
                }

                for (int j = 1; j < range; j++)
                {
                    rangeArr[j] += rangeArr[j - 1];
                }

                for (int k = 0; k < input.Length; k++)
                {
                    output[rangeArr[input[k]] - 1] = input[k];
                    rangeArr[input[k]] -= 1;
                }

                if (orderType == SortOrderType.Asc)
                {
                    for (int x = 1; x < input.Length; x++)
                    {
                        input[x] = output[x];
                    }
                }
                else
                {
                    int y = 0;
                    for (int x = input.Length - 1; x >= 0; x--)
                    {
                        input[x] = output[y];
                        y += 1;
                    }
                }
            }

            return input;
        }
    }
}
