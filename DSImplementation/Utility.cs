using System;
using System.Text;

namespace DSImplementation
{
    public static class Utility
    {
        public static int[] GetInputData(int inputSize)
        {
            var input = new int[inputSize];
            Random rnd = new Random();

            for (int i = 0; i < inputSize; i++)
            {
                input[i] = rnd.Next(100);
            }

            return input;
        }

        public static char[] GetInputCharArray(int outputSize)
        {
            var input = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var output = new char[outputSize];

            Random rnd = new Random();

            for (int i = 0; i < outputSize; i++)
            {
                output[i] = input[rnd.Next(input.Length)];
            }

            return output;
        }

        public static int[] InitializeArray(int inputSize)
        {
            int[] input = new int[inputSize];

            for (int i = 0; i < inputSize; i++)
            {
                input[i] = -999;
            }

            return input;
        }

        public static void PrintAll(int[] data)
        {
            Console.Write("Input : ");
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i] + ", ");
            }

            var output = builder.Length != 0 ? builder.ToString(0, builder.Length - 2) : string.Empty;

            Console.WriteLine(output);
        }

        public static void PrintFiltered(int[] data)
        {
            Console.Write("Input : ");
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != -999)
                {
                    builder.Append(data[i] + ", ");
                }
            }

            var output = builder.Length != 0 ? builder.ToString(0, builder.Length - 2) : string.Empty;
            
            Console.WriteLine(output);
        }
    }
}
