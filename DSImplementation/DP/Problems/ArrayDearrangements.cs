using System;

namespace DSImplementation.DP.Problems
{
    /// <summary>
    /// http://www.geeksforgeeks.org/count-derangements-permutation-such-that-no-element-appears-in-its-original-position/
    /// </summary>
    public class ArrayDearrangements
    {
        public void Solve()
        {
            int[] arr = Utility.GetInputData(4);

            int deArrangementCount = GetDeArrangements(arr.Length);
            int dpDeArrangementCount = DPGetDeArrangements(arr.Length);

            Utility.PrintAll(arr);
            Console.WriteLine("Dearrangement count Rec: {0}", deArrangementCount);
            Console.WriteLine("Dearrangement count DP: {0}", dpDeArrangementCount);
        }

        private int DPGetDeArrangements(int count)
        {
            int[] arr = new int[count + 1];

            for (int i = 0; i <= count; i++)
            {
                if (i == 0)
                    arr[i] = 1;
                else if (i == 1)
                    arr[i] = 0;
                else if (i == 2)
                    arr[i] = 1;
                else
                    arr[i] = (i - 1) * (arr[i - 2] + arr[i - 1]);
            }

            return arr[count];
        }

        private int GetDeArrangements(int count)
        {
            int deArrangements = 0;

            if (count == 0) return 1;
            if (count == 1) return 0;
            if (count == 2) return 1;

            deArrangements = (count - 1) * (GetDeArrangements(count - 2) + GetDeArrangements(count - 1));

            return deArrangements;
        }
    }
}
