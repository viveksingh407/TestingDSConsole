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
            ArrayDearrangements arr = new ArrayDearrangements();
            arr.Solve();

            //EditDistance ed = new EditDistance();
            //ed.Problem();
        }
    }
}
