using System;

namespace MaximumConsecutiveNumbers
{
    class Program
    {
        static int[] input1 = new int[] { 1, 1, 0, 1, 1, 1 };
        static int[] input2 = new int[] { 1, 0, 1, 1, 0, 1 };
        static int[] input3 = new int[] { 12, 345, 2, 6, 7896 };
        static int[] input4 = new int[] { -4, -1, 0, 3, 10 };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! These is a test to get the max consecutive numbers in an array.");
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Loading array to use in this exercise...");

            PrintingArray(input1);

            var maxConsecutive = GetMaxConsecutiveNumber(input1);

            Console.WriteLine();
            Console.WriteLine($"The max consecutive number is: {maxConsecutive}");
            Console.WriteLine();
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Loading array to use in this exercise...");

            PrintingArray(input3);

            var evenDigits = EvenDigitNumber(input3);

            Console.WriteLine();
            Console.WriteLine($"Even digits count in the array is: {evenDigits}");
            Console.WriteLine();
            Console.WriteLine("Press any <KEY> to continue...");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Loading array to use in this exercise...");

            PrintingArray(input4);

            var squareValuesArray = GetSquareNumbersInArray(input4);

            Console.WriteLine();
            Console.WriteLine("Array after calculating square numbers");

            PrintingArray(squareValuesArray);

            var descendingSortArray = OrderDescendingArray(input4);

            Console.WriteLine();
            Console.WriteLine("Array after sorting in DESC order");

            PrintingArray(descendingSortArray);

            var ascendingSortArray = OrderAscendingArray(input4);

            Console.WriteLine();
            Console.WriteLine("Array after sorting in ASC order");

            PrintingArray(ascendingSortArray);

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

        private static int GetMaxConsecutiveNumber(int[] input)
        {
            int maxConsecutive = 0;
            int tempConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 1)
                {
                    tempConsecutive++;
                }
                else 
                {
                    if (maxConsecutive < tempConsecutive) maxConsecutive = tempConsecutive;
                    tempConsecutive = 0;
                }
            }

            if (maxConsecutive < tempConsecutive) maxConsecutive = tempConsecutive;

            
            return maxConsecutive;
        }

        private static int EvenDigitNumber(int[] input)
        { 
            int evenNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var digits = input[i].ToString().ToCharArray();
                if (digits.Length % 2 == 0)
                {
                    evenNumber++;
                }
            }

            return evenNumber;
        }

        private static int[] GetSquareNumbersInArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = (int)Math.Pow(input[i], 2);
            }

            return input;
        }

        private static int[] OrderDescendingArray(int[] input)
        {
            int tempValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((j + 1) >= input.Length) break;

                    if (input[j + 1] > input[j])
                    {
                        tempValue = input[j];
                        input[j] = input[j+1];
                        input[j + 1] = tempValue;
                    }
                }
            }

            return input;
        }


        private static int[] OrderAscendingArray(int[] input)
        {
            int tempValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if ((j + 1) >= input.Length) break;

                    if (input[j + 1] < input[j])
                    {
                        tempValue = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = tempValue;
                    }
                }
            }

            return input;
        }
    }
}
