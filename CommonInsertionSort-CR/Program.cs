using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonInsertionSort_CR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15] {9,4,13,42,56,21,1,19,42,42,40,109,3,8,99};

            Console.WriteLine("Final OutPut");
            PrintIntegerArray(PerformInsertionSort(numbers));
            Console.ReadLine();
        }

        static int[] PerformInsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                    PrintIntegerArray(inputArray);
                }
            }
            return inputArray;         
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + ", ");
            }
            Console.WriteLine("End of Array");
            Console.ReadLine();
        }


        //test this code vigorously
        
        public static int[] InsertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;
        }

        //try to implement the upper bound and shift method use the above method as a base, create an Upper Bound algorith Method first.

    }
}
