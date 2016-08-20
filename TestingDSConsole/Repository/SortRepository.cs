using System;
using DSImplementation;
using DSImplementation.Sort;

namespace TestingDSConsole.Repository
{
    public class SortRepository
    {
        public void SortImplementations()
        {
            QuickSortImplementation();
        }

        private void QuickSortImplementation()
        {
            int len = 10;
            int[] input = new int[len];
            int[] output = new int[len];

            Console.WriteLine("Merge Sort: ");

            QuickSort qs = new QuickSort();
            input = Utility.GetInputData(len);
            Utility.PrintAll("Output: ", input);
            output = qs.Sort(input, SortOrderType.Asc);
            Utility.PrintAll("Output: ", input);
            output = qs.Sort(input, SortOrderType.Desc);
            Utility.PrintAll("Output: ", input);
        }
    }
}
