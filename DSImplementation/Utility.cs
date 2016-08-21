using System;
using System.Collections.Generic;
using System.Text;

namespace DSImplementation
{
    public static class Utility
    {
        public static int[] GetInputData(int inputSize)
        {
            return GetInputData(inputSize, 100);
        }

        public static int[] GetInputData(int inputSize, int maxValue)
        {
            var input = new int[inputSize];
            Random rnd = new Random();

            for (int i = 0; i < inputSize; i++)
            {
                input[i] = rnd.Next(maxValue);

                if (input[i] == 0)
                {
                    i -= 1;
                }
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

        public static T[] InitializeGenericArray<T>(int inputSize)
        {
            T[] input = new T[inputSize];

            for (int i = 0; i < inputSize; i++)
            {
                input[i] = default(T);
            }

            return input;
        }

        public static void PrintAll(int[] data)
        {
            PrintAll("Input : ", data);
        }

        public static void PrintAll(string text, int[] data)
        {
            PrintAll("Input : ", data, data.Length);
        }

        public static void PrintAll(string text, int[] data, int counter)
        {
            Console.Write(text);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < counter; i++)
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

        public static void PrintFilteredGenericArray<T>(T[] data)
        {
            Console.Write("Input : ");
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(data[i], default(T)))
                {
                    builder.Append(data[i] + ", ");
                }
            }

            var output = builder.Length != 0 ? builder.ToString(0, builder.Length - 2) : string.Empty;

            Console.WriteLine(output);
        }

        public static void PrintMatrix<T>(string text, T[,] data)
        {
            string delimiter = string.Empty;
            Console.Write(text);

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    delimiter = (j < data.GetLength(1) - 1) ? ", " : string.Empty;
                    Console.Write(data[i, j] + delimiter);
                }

                Console.WriteLine();
            }
        }
    }
}
