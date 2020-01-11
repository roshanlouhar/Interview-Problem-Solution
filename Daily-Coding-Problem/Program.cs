using System;
using System.Collections;
using System.Collections.Generic;

namespace Daily_Coding_Problem
{
    class Interval
    {
        public int Buy { get; set; }
        public int Sell { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
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

            #region // This function finds the buy sell schedule for maximum profit
            // stock prices on consecutive days
            //var price = new int[] { 100, 180, 260, 310, 40, 535, 695 };
            // function call
            //StockBuySell(price);
            #endregion

            #region Given a list of numbers, return whether any two sums to k.
            int k = 100;
            int result = FindSumOfPrimeNumbers(k);
            #endregion




            Console.ReadKey();
        }

        private static int FindSumOfPrimeNumbers(int k)
        {
            int sum = 1;
            int ctr = 0, n = 0;

            while (ctr < 100)
            {
                n++;
                if (n % 2 != 0)
                {
                    // check if the number is even
                    if (Is_Prime(n))
                    {
                        sum += n;
                    }
                }
                ctr++;
            }


            //int sum = 0;
            //bool[] tempArr = new bool[k + 1];
            //for (int i = 2; i * i <= k; i++)
            //{
            //    if (tempArr[i] == false)
            //    {
            //        for (int j = i * 2; j <= k;)
            //        {
            //            tempArr[j] = true;
            //            j += i;
            //        }
            //    }
            //}
            //for (int p = 2; p <= k; p++)
            //    if (!tempArr[p])
            //        sum += p;

            return sum;
        }

        private static bool Is_Prime(int n)
        {
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void StockBuySell(int[] price)
        {
            // Prices must be given for at least two days
            if (price.Length == 1)
                return;

            // solution array
            var sol = new List<Interval>();

            var buyIndex = -1;

            for (int i = 0; i < price.Length - 1; i++)
            {
                if (buyIndex < 0)
                {
                    if (price[i] <= price[i + 1])
                        buyIndex = i;
                }
                else
                {
                    if (price[i] > price[i + 1] || i + 1 == price.Length - 1)
                    {
                        sol.Add(new Interval { Buy = buyIndex, Sell = i });
                        buyIndex = -1;
                    }
                }
            }

            // print solution
            if (sol.Count == 0)
                Console.WriteLine("There is no day when buying the stock "
                + "will make profit");
            else
                for (int j = 0; j < sol.Count; j++)
                    Console.WriteLine("Buy on day: " + sol[j].Buy
                    + " "
                    + "Sell on day : " + sol[j].Sell);

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
