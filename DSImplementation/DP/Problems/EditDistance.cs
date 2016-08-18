using System;

namespace DSImplementation.DP.Problems
{
    /// <summary>
    /// http://www.geeksforgeeks.org/dynamic-programming-set-5-edit-distance/
    /// </summary>
    public class EditDistance
    {
        public void Solve()
        {
            string firstString = "geek";
            string secondString = "gesek";

            Console.WriteLine("First String: {0}, Second String: {1}", firstString, secondString);
            int output = CalculateEditDistance(firstString, secondString);
            Console.WriteLine("Output Rec: {0}", output);

            int ed = DPCalculateEditDistance(firstString, secondString);
            Console.WriteLine("Output DP: {0}", ed);
        }

        private int DPCalculateEditDistance(string firstString, string secondString)
        {
            int len1 = firstString.Length;
            int len2 = secondString.Length;
            int[,] arr = new int[len1 + 1, len2 + 1];

            for (int i = 0; i <= len1; i++)
            {
                for (int j = 0; j <= len2; j++)
                {
                    if (i == 0)
                    {
                        arr[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        arr[i, j] = i;
                    }
                    else
                    {
                        if (firstString[i - 1] != secondString[j - 1])
                        {
                            arr[i, j] = 1 + Min(arr[i, j - 1], arr[i - 1, j], arr[i - 1, j - 1]);
                        }
                        else
                        {
                            arr[i, j] = Min(arr[i, j - 1], arr[i - 1, j], arr[i - 1, j - 1]);
                        }
                    }
                }
            }

            return arr[len1, len2];
        }

        private int CalculateEditDistance(string firstString, string secondString)
        {
            int len1 = firstString.Length;
            int len2 = secondString.Length;

            if (len1 == 0)
                return len2;
            if(len2 == 0)
                return len1;

            if (firstString[len1 - 1] != secondString[len2 - 1])
            {
                return 1 + Min(
                    CalculateEditDistance(firstString, secondString.Substring(0, len2 - 1)),
                    CalculateEditDistance(firstString.Substring(0, len1 - 1), secondString),
                    CalculateEditDistance(firstString.Substring(0, len1 - 1), secondString.Substring(0, len2 - 1))
                    );
            }
            else
            {
                return CalculateEditDistance(firstString.Substring(0, len1 - 1), secondString.Substring(0, len2 - 1));
            }
        }

        private int Min(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

    }
}
