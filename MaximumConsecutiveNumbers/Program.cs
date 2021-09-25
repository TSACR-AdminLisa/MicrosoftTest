using System;

namespace MaximumConsecutiveNumbers
{
    class Program
    {
        static int[] input1 = new int[] { 1,1,0,1,1,1 };
        static int[] input2 = new int[] { 1,0,1,1,0,1 };

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
        }

        private static void PrintingArray(int[] emailArray)
        {
            for (int i = 0; i < emailArray.Length; i++)
            {
                Console.WriteLine(emailArray[i]);
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
    }
}
