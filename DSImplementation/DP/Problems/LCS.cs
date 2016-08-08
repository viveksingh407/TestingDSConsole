using System;

namespace DSImplementation.DP.Problems
{
    public class LCS : IProblem
    {
        public int[] InputArray { get; set; }
        public string InputString { get; set; }

        public void Solve()
        {
            string input1 = string.Empty;
            string input2 = string.Empty;
            int output = 0;

            input1 = "ACDH";
            input2 = "ADFH";

            Console.WriteLine("Input String 1: {0}, Input String 2: {0}", input1, input2);
            
            output = getLCS(input1, input2, input1.Length, input2.Length, "Root Method");

            Console.WriteLine("Output: {0}", output);
        }

        private int getLCS(string X, string Y, int m, int n, string calleeMethodType)
        {
            var a = X.Substring(0, m);
            var b = Y.Substring(0, n);

            if (m == 0 || n == 0)
            {
                return 0;
            }

            if (X[m - 1] == Y[n - 1])
                return 1 + getLCS(X, Y, m - 1, n - 1, "Same Char Method");
            else
                return max(getLCS(X, Y, m, n - 1, "First Method"), getLCS(X, Y, m - 1, n, "Second Method"));
        }

        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
