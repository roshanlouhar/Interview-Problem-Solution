using System;
using System.Collections.Generic;

namespace Daily_Coding_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region Given a list of numbers, return whether any two sums to k.
            //string Str = "10 15 3 7";
            //int[] array = Array.ConvertAll(Str.Split(' '), int.Parse);
            //int k = 17;
            //bool result = FindSumInArray(array , k);
            #endregion

            #region Given an array of integers return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at self.
            //string Str = "10 3 5 6 2";
            //int[] array = Array.ConvertAll(Str.Split(' '), int.Parse);
            //FindProductArrayExceptSelf(array);
            #endregion






            Console.ReadKey();
        }

        private static void FindProductArrayExceptSelf(int[] array)
        {
            int size = array.Length;
            int[] ProdArray = new int[size];

            //int[] Left = new int[size];
            //int[] Right = new int[size];
            //Left[0] = 1;
            //Right[size - 1] = 1;
            //for (int i = 1; i < size; i++)
            //{
            //    Left[i] = Left[i - 1] * array[i - 1];
            //}
            //for (int i = size - 2; i >= 0; i--)
            //{
            //    Right[i] = Right[i + 1] * array[i + 1];
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    ProdArray[i] = Left[i] * Right[i];
            //}

            int i, temp = 1;

            for (i = 0; i < size; i++)
            {
                ProdArray[i] = 1;
            }

            for (i = 0; i < size; i++)
            {
                ProdArray[i] = temp;
                temp = temp * array[i];
            }

            temp = 1;
            for (i = size - 1; i >= 0; i--)
            {
                ProdArray[i] = ProdArray[i] * temp;
                temp = temp * array[i];
            }


            for (i = 0; i < size; i++)
            {
                Console.Write(ProdArray[i] + " ");
            }


        }

        private static bool FindSumInArray(int[] array, int k)
        {
            bool result = false;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int SubNumber = Math.Abs(k - array[i]);
                if (set.Contains(SubNumber))
                {
                    result = true;
                    break;
                }
                else
                {
                    set.Add(array[i]);
                }
            }

            return result;
        }
    }
}
