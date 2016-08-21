using System;

namespace DSImplementation.Sort
{
    public class RadixSort
    {
        public int[] Sort(int[] input, int range)
        {
            return Sort(input, range, SortOrderType.Asc);
        }

        public int[] Sort(int[] input, int range, SortOrderType orderType)
        {
            if (input == null)
                throw new InvalidOperationException("Array is null.");
            else
            {
                return RS(input, range, SortOrderType.Asc);
            }
        }

        public int[] RS(int[] input, int range, SortOrderType orderType)
        {
            return input;
        }
    }
}
