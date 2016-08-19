using System;

namespace DSImplementation.DP.Problems
{
    public class BionomialCoefficient
    {
        public void Solve()
        {
            //int n = 4;
            //int k = 2;

            int n = 5;
            int k = 2;

            int coefficient = BC(n, k);
            int coefficientDP = DPBC(n, k);
            int coefficientSPDP = SPDPBC(n, k);
            Console.WriteLine("N: {0}, k: {1}, Coefficient: {2}", n, k, coefficient);
            Console.WriteLine("N: {0}, k: {1}, Coefficient: {2}", n, k, coefficientDP);
            Console.WriteLine("N: {0}, k: {1}, Coefficient: {2}", n, k, coefficientSPDP);
        }

        private int SPDPBC(int n, int k)
        {
            int[] arr = new int[k + 1];

            arr[0] = 1;

            for (int i = 0; i <= n; i++)
            {
                for (int j = Min(i, k); j > 0; j--)
                {
                    arr[j] = arr[j] + arr[j - 1];
                }
            }

            return arr[k];
        }

        private int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        private int DPBC(int n, int k)
        {
            int[,] arr = new int[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Min(i, k); j++)
                {
                    if (j == 0 || i == j)
                        arr[i, j] = 1;
                    else
                    {
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    }
                }
            }

            return arr[n, k];
        }

        private int BC(int n, int k)
        {
            int output = 0;

            if (k == 0 || k == n)
                return 1;
            else
            {
                output = BC(n - 1, k - 1) + BC(n - 1, k);
            }

            return output;
        }
    }
}
