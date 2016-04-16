using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation.DP
{
    public interface IProblem
    {
        int[] InputArray { get; set; }
        string InputString { get; set; }

        void Solve();
    }
}
