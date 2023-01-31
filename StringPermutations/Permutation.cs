using System;
namespace StringPermutations
{
    public class Permutation
    {
        public Permutation()
        {
        }

        public static void PrintPermutation(char[] input, string extra = "")
        {
            if (input.Length == 1)
            {
                Console.Write(extra + input[0] + "\n");
                return;
            }
            for (int i = 0; i < input.Length; i++) PrintPermutation(RemoveChar(input, i), extra + input[i]);
        }

        public static string Permutations(char[] input, string extra = "")
        {
            string result = "";
            if (input.Length == 1) return (extra + input[0] + "\n");
            for (int i = 0; i < input.Length; i++) result += Permutations(RemoveChar(input, i), extra + input[i]);
            return result;
        }

        public static char[] RemoveChar(char[] input, int removeAt)
        {
            char[] result = new char[input.Length - 1];
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (removeAt == i) continue;
                result[j] = input[i];
                j++;
            }
            return result;
        }

        public static int Factorial(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            return input * Factorial(input - 1);
        }
    }
}

