using System;

namespace DSImplementation.DP.Problems
{
    /// <summary>
    /// http://www.geeksforgeeks.org/dynamic-programming-set-6-min-cost-path/
    /// </summary>
    public class MinimumCostPath
    {
        public void Solve()
        {
            int[,] data = new int[3, 3] { { 1, 2, 3 }, { 4, 8, 2}, { 1, 5, 3} };

            Utility.PrintMatrix("input: ", data);

            int output = MCP(data, data.GetLength(0), data.GetLength(1));
            Console.WriteLine("Output (Rec): {0}", output);

            int outputDP = DPMCP(data, data.GetLength(0), data.GetLength(1));
            Console.WriteLine("Output (Rec): {0}", outputDP);
        }

        private int DPMCP(int[,] arr, int row, int col)
        {
            int[,] data = new int[row + 1, col + 1];

            for (int i = 0; i <= arr.GetLength(0); i++)
            {
                for (int j = 0; j <= arr.GetLength(1); j++)
                {
                    if (i == 0)
                        data[i, j] = j;
                    else if (j == 0)
                        data[i, j] = i;
                    else
                        data[i, j] = arr[i - 1, j - 1] + Min(data[i - 1, j], data[i, j - 1], data[i - 1, j - 1]);
                }
            }

            return data[row, col];
        }

        private int MCP(int[,] arr, int row, int col)
        {
            if (row == 0)
                return col;
            else if (col == 0)
                return row;
            else
                return arr[row - 1,col - 1] + Min(MCP(arr, row - 1, col), MCP(arr, row, col - 1), MCP(arr, row - 1, col - 1));
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
