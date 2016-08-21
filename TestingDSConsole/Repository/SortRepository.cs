using System;
using DSImplementation;
using DSImplementation.Sort;

namespace TestingDSConsole.Repository
{
    public class SortRepository
    {
        public void SortImplementations()
        {
            //QuickSortImplementation();
            CountingSortImplementation();
            //RadixSortImplementation();
        }

        private void QuickSortImplementation()
        {
            int len = 10;
            int[] input = new int[len];
            int[] output = new int[len];

            Console.WriteLine("Quick Sort: ");

            QuickSort qs = new QuickSort();
            input = Utility.GetInputData(len);
            Utility.PrintAll("Output: ", input);
            output = qs.Sort(input, SortOrderType.Asc);
            Utility.PrintAll("Output: ", input);
            output = qs.Sort(input, SortOrderType.Desc);
            Utility.PrintAll("Output: ", input);
        }

        private void CountingSortImplementation()
        {
            int len = 8;
            int range = 10;
            int[] input = new int[len];
            int[] output = new int[len];

            Console.WriteLine("Counting Sort: ");

            CountingSort s = new CountingSort();
            input = Utility.GetInputData(len, range);
            Utility.PrintAll("Input: ", input);
            output = s.Sort(input, range, SortOrderType.Asc);
            Utility.PrintAll("Output: ", input);
            output = s.Sort(input, range, SortOrderType.Desc);
            Utility.PrintAll("Output: ", input);
        }

        private void RadixSortImplementation()
        {
            int len = 8;
            int range = len*len;
            int[] input = new int[len];
            int[] output = new int[len];

            Console.WriteLine("Radix Sort: ");

            RadixSort s = new RadixSort();
            input = Utility.GetInputData(len, range);
            Utility.PrintAll("Input: ", input);
            output = s.Sort(input, range, SortOrderType.Asc);
            Utility.PrintAll("Output: ", input);
            output = s.Sort(input, range, SortOrderType.Desc);
            Utility.PrintAll("Output: ", input);
        }
    }
}
