using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation.DP.Problems
{
    public class ReverseString : IProblem
    {
        public int[] InputArray { get; set; }
        public string InputString { get; set; }

        public void Solve()
        {
            //var input = "abcde sdfra rbt";
            Console.WriteLine("Input : ");
            InputString = Console.ReadLine();

            var output = ReverseCompleteString(InputString);
            Print(output);

            output = ReverseWords(InputString);
            Print(output);
        }

        public char[] ReverseCompleteString(string input)
        {
            var i = 0;
            var j = input.Length - 1;
            char[] newString = new char[input.Length];

            while (i <= j)
            {
                newString[i] = input[j];
                newString[j] = input[i];
                i += 1;
                j -= 1;
            }

            return newString;
        }

        public char[] ReverseWords(string input)
        {
            var reversedString = ReverseCompleteString(input);
            char[] newString = new char[reversedString.Length];
            var lastIndex = reversedString.Length;
            var currentIndex = 0;

            for (int i = reversedString.Length - 1; i >= 0; i--)
            {
                if (reversedString[i] == ' ')
                {
                    for (int j = i + 1; j < lastIndex; j++)
                    {
                        newString[currentIndex] = reversedString[j];
                        currentIndex += 1;
                    }

                    newString[currentIndex] = ' ';
                    currentIndex += 1;
                    lastIndex = i;
                }
            }

            for (int j = 0; j < lastIndex; j++)
            {
                newString[currentIndex] = reversedString[j];
                currentIndex += 1;
            }

            return newString;
        }

        private void Print(char[] data)
        {
            Console.Write("Output : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
            }

            Console.WriteLine();
        }
    }
}
