using System;
using DSImplementation.DP.Problems;

namespace TestingDSConsole.Repository
{
    public class DPRepository
    {
        public void DPQuestions()
        {
            Problems();
        }

        private void Problems()
        {
            //ArrayDearrangements dp = new ArrayDearrangements();
            //EditDistance dp = new EditDistance();
            //MinimumCostPath dp = new MinimumCostPath();
            //CoinChange dp = new CoinChange();
            BionomialCoefficient dp = new BionomialCoefficient();

            dp.Solve();
        }
    }
}
