using System;

namespace DuplicateValuesExcersises
{
    class Program
    {
        static int[] input1 = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
        static int[] input2 = new int[] { 1, 2, 3 };

        static void Main(string[] args)
        {
            Console.WriteLine("Excersise 1. Duplicate Zero and move value to the right.");
            Console.WriteLine();
            Console.WriteLine("\t Given array: ");
            
            PrintingArray(input1);
            DuplicateValueAndMoveRight(ref input1, 0);

            Console.WriteLine();
            Console.WriteLine("\t After execution: ");
            PrintingArray(input1);

            Console.WriteLine();
            Console.WriteLine("Excersise 2. Duplicate Zero and move value to the right.");
            Console.WriteLine();
            Console.WriteLine("\t Given array: ");

            PrintingArray(input2);
            DuplicateValueAndMoveRight(ref input2, 0);

            Console.WriteLine();
            Console.WriteLine("\t After execution: ");
            PrintingArray(input2);

            Console.WriteLine();
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();
        }

        private static void PrintingArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"\t {input[i]}");
            }
        }

        private static void DuplicateValueAndMoveRight(ref int[] input, int valueToDuplicate)
        {
            if (input == null || input.Length == 0) return;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == valueToDuplicate)
                {
                    for (int j = input.Length - 1; j > i; j--)
                    {
                        input[j] = input[j - 1];
                    }
                    i++; // we don't want to traverse over the duplicate zero
                }
            }
        }
    }
}
