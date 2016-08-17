using System;

namespace DSImplementation.Strings
{
    public class Problems
    {
        public void Solve()
        { }

        public void MatchPatternNaiveImplementation()
        {

            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Pattern: ");
            var pattern = Console.ReadLine();

            var inputLength = input.Length;
            var patternLength = pattern.Length;
            var isPatternMatching = false;
            
            if (!(patternLength > 0 && inputLength > 0 && patternLength > inputLength))
            {
                for (int i = 0; i < inputLength; i++)
                {
                    int j;
                    for (j = 0; j < patternLength && i + j < inputLength; j++)
                    {
                        if (input[i + j] != pattern[j])
                            break;
                    }

                    if (j == patternLength)
                    {
                        isPatternMatching = true;
                        Console.WriteLine("Pattern is present");
                        break;
                    }
                }
            }

            if(!isPatternMatching)
                Console.WriteLine("Pattern not present.");
        }
    }
}
