using System;

namespace ComplexArrayExcersises
{
    class Program
    {
        static int[] array1 = new int[] { 9, 1, 2, 3, 0, 0, 0 };
        static int[] array2 = new int[] { 2, 5, 6, 10, 4 };
        static int m = array1.Length;
        static int n = array2.Length;

        static void Main(string[] args)
        {
            Console.WriteLine("1. Merge Sorted Array.");
            Console.WriteLine();

            Console.WriteLine($"Array 1 in given input. Array lenght: {array1.Length}.");
            PrintingArray(array1);

            Console.WriteLine();
            Console.WriteLine($"Array 2 in given input. Array lenght: {array2.Length}.");
            PrintingArray(array2);

            int[] arrayCopy = new int[m];
            Array.Copy(array1, arrayCopy, m);

            array1 = MergeArrays(arrayCopy, array2);
            Array.Sort(array1);

            Console.WriteLine();
            Console.WriteLine($"Array 1 after merging and sorting.");
            PrintingArray(array1);

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

        

        private static int[] MoveZeroToRightOfArray(int[] input)
        {
            int tempValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((j + 1) >= input.Length) break;

                    if (input[j] == 0)
                    {
                        tempValue = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = tempValue;
                    }
                }
            }

            return input;
        }

        private static int[] MergeArrays(int[] input1, int[] input2)
        {
            // Read pointers for copyArray and array2
            int pointer1 = 0;
            int pointer2 = 0;

            // Compare elements from copyArray and array2 and write the smallest to array1.
            for (int i = 0; i < input1.Length; i++)
            {
                if (pointer2 >= n || (pointer1 < m && input1[pointer1] < input2[pointer2]))
                {
                    array1[i] = input1[pointer1++];
                }
                else
                {
                    array1[i] = input2[pointer2++];
                }
            }

            return array1;
        }
    }
}
