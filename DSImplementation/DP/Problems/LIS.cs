using System;

namespace DSImplementation.DP.Problems
{
    public class LIS : IProblem
    {
        public int[] InputArray { get; set; }
        public string InputString { get; set; }
        private int max_ref;

        public void Solve()
        {
            Console.Write("Input Array : ");
            //var input = new int[] { 41, 61, 16, 48, 37, 29, 52, 61, 55, 36 };
            var input = new int[] { 10, 9, 11};
            Print(input);

            max_ref = 1;
            _lis(input, input.Length);

            Console.WriteLine("Output: {0}", max_ref);
        }

        private int _lis(int[] arr, int n)
        {
            if (n == 1)
                return 1;

            int res, max_ending_here = 1;

            for (int i = 1; i < n; i++)
            {
                res = _lis(arr, i);
                Console.WriteLine("i: {0}, res: {1}", i, res);

                if (arr[i - 1] < arr[n - 1] && res + 1 > max_ending_here)
                    max_ending_here = res + 1;
            }

            if (max_ref < max_ending_here)
                max_ref = max_ending_here;

            return max_ending_here;
        }

        private void Print(int[] arr)
        {
            var output = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                output += arr[i] + ", ";
            }

            Console.WriteLine(output.Substring(0, output.Length - 2));
        }
    }
}