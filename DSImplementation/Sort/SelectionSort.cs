using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation.Sort
{
    public class SelectionSort
    {
        public int[] Sort(int[] input)
        {
            return SortData(input);
        }

        private int[] SortData(int[] input)
        {
            var temp = 0;
            var minElement = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                minElement = i;

                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < input[minElement])
                    {
                        minElement = j;
                    }
                }

                if (i != minElement)
                {
                    temp = input[i];
                    input[i] = input[minElement];
                    input[minElement] = temp;
                }
            }

            return input;
        }
    }
}
