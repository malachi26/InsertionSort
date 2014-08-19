using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonInsertionSort_CR
{
    class ChallengeCode
    {
         /// <summary>
        /// Constructor if needed
        /// </summary>
        public ChallengeCode()
        {

        }
        //Simple Intro
        public static void RunChallenge1()
        {
            string V = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] ar = Convert.ToInt32(Console.ReadLine().Split(' ').ToArray());
            string[] ar = Console.ReadLine().Split(' ');


            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == V)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        

        /// <summary>
        /// Insertion Sort 1
        /// </summary>
        public void insertionSort(int[] ar)
        {
            int Num = ar[ar.Length - 1];

            for (int i = ar.Length - 1; i >= 0; --i)
            {
                string output = "";
                if (ar[i] > Num)
                {
                    ar[i + 1] = ar[i];
                }
                else if (ar[i] < Num)
                {
                    ar[i + 1] = Num;
                    i = -1;
                }

                if (i == 0)
                {
                    ar[0] = Num;
                }
                foreach (int num in ar)
                {
                    output += num.ToString() + " ";
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
        /* Tail starts here */
        /* Tail starts here */
        public void InsertionSort1()
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }
            insertionSort(_ar);
        }

    }
}
