using System;

namespace DSImplementation.DP.Problems
{
    public class CoinChange
    {
        public void Solve()
        {
            //int n = 4;
            //int[] coins = new int[3] { 1, 2, 3 };
            int n = 10;
            int[] coins = new int[4] { 2, 3, 5 , 6 };

            int output = GetCoinChange(n, coins, coins.Length);

            Console.WriteLine("N: {0}", n);
            Utility.PrintAll("Coins: ", coins);
            Console.WriteLine("Output (Rec): {0}", output);

            //int change = DPGetCoinChange(n, coins, coins.Length);
            //Console.WriteLine("Output (DP): {0}", change);
        }

        //TODO
        //private int DPGetCoinChange(int n, int[] coins, int coinCount)
        //{
        //    int[] data = new int[coinCount + 1];
        //    var a = 0;
        //    var b = 0;

        //    for (int i = 0; i <= coinCount; i++)
        //    {
        //        if (i == 0)
        //            return 1;
        //        else if (i < 0)
        //            return 0;
        //        else if (i - coins.Length <= 0 && i > 0)
        //            return 0;
        //        else
        //        {
        //            a = data[i - 1];
        //            b = (i - data[i - 1]);
        //            data[i] = a + b;
        //        }
        //    }

        //    return data[coinCount];
        //}

        private int GetCoinChange(int n, int[] coins, int coinCount)
        {
            int output = 0;

            if (n == 0)
                return 1;
            else if (n < 0)
                return 0;
            else if (coinCount <= 0 && n > 0)
                return 0;
            else
            {
                output = GetCoinChange(n, coins, coinCount - 1) + GetCoinChange(n - coins[coinCount - 1], coins, coinCount);
            }

            return output;
        }
    }
}
