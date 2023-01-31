// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = "123";
char[] cInput = input.ToCharArray();

//Print Permutation
StringPermutations.Permutation.PrintPermutation(cInput);

//Return Permutated strings
string permutations = StringPermutations.Permutation.Permutations(cInput);

Console.WriteLine(permutations); 

////define a matrix of size = input
//char[][] chars = new char[StringPermutations.Permutation.Factorial(input.Length)][];
//for (int i = 0; i < chars.Length; i++)
//{
//    chars[i] = new char[input.Length];
//}

////Fill the matrix
//for (int i = 0; i < input.Length; i++)
//{
//    for (int j = 0; j < chars.Length; j++)
//    {
//        chars[j][i] = cInput[i];
//    }
//}

