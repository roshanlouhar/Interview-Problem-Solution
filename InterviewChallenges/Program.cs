using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            #region biggest sum 
            //Console.WriteLine("Hello World!");
            //int[] prices = { 1, 3, 3, 2, 5 };
            //int sum = biggestSum(intArr);
            #endregion

            #region find final price salesman problem 
            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(3);
            //list.Add(1);
            //list.Add(2);
            //list.Add(4);
            //list.Add(2);
            //list.Add(1);
            //list.Add(3);
            //list.Add(3);
            //list.Add(2);
            //list.Add(5);
            //finalPrice(list);
            #endregion

            #region find excel column
            //int number = 100;
            // FindColumnName(number);
            #endregion

            #region find max substring without repeated char in string
            //string str = "GOOGLEBABAKIJAYHO";
            //FindMaxSubstringNonRepeatedChar(str);
            #endregion

            #region put the linkedlist in specific order like 1 , n ,2 ,n-1 ,3 , n-2.....4
            //ArrangeLinkedListAlternateOrder();
            #endregion

            #region longest rising start problem @ Okra Solar
            //LongestRisingSequence();
            #endregion

            #region PrintFizzBuzzLogic
            //int count = Convert.ToInt32(Console.ReadLine());
            //string str = Console.ReadLine();
            //int[] numbers = Array.ConvertAll(str.Split(' '), int.Parse);

            //for (int i = 1; i < count; i++)
            //{
            //    PrintFizzBuzzLogic(numbers[i - 1]);
            //}
            #endregion

            #region repeating element in array with O(n) time and O(1) space
            //RepeatingElements();
            #endregion


            #region cimpress getting profit gain
            //int NoOfVillage = 100; //Convert.ToInt32(Console.ReadLine());
            //string VillageProfilestr = "1 3 13 31 33 34 44 46 50 62 64 65 69 70 74 75 77 94 105 108 109 111 114 115 116 126 128 132 139 145 146 149 153 157 158 164 166 175 178 187 188 195 197 198 201 204 207 208 209 210 212 218 222 237 242 244 247 252 255 263 264 266 273 276 277 284 292 294 300 308 325 335 338 342 346 348 351 352 353 354 356 365 370 373 382 384 385 398 405 410 426 427 428 447 448 455 457 459 465 497"; //Console.ReadLine();
            //int[] Profit = Array.ConvertAll(VillageProfilestr.Split(' '), int.Parse);
            //int MaxProfit = GetMaxProfit(Profit);
            //Console.WriteLine(MaxProfit);

            #endregion


            Console.ReadKey();
        }

        private static int GetMaxProfit(int[] Profit)
        {
            int size = Profit.Length;

            int i = 0, j = 0;
            Queue<int> AllMaxProfit = new Queue<int>();

            //Queue<int> queueProfit = new Queue<int>();
            int prevProfit = 0;

            for (j = 0; j < size; j++)
            {
                Queue<int> TempProfit = new Queue<int>();
                for (i = 0 + j; i < size; i++)
                {
                    if (i == j)
                    {
                        TempProfit.Enqueue(Profit[i]);
                        prevProfit = Profit[i];
                    }
                    else
                    {
                        if ((Profit[i] % prevProfit == 0))
                        {
                            TempProfit.Enqueue(Profit[i]);
                            prevProfit = Profit[i];
                        }
                    }                    
                }                
                AllMaxProfit.Enqueue(TempProfit.Sum());
            }

            return AllMaxProfit.Max();
        }

        private static void RepeatingElements()
        {
            int[] numRay1 = { 0, 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.Write("The repeating" + " elements are : ");
            for (int i = 0; i < numRay1.Length; i++)
            {
                int temp = Math.Abs(numRay1[i]);
                if (numRay1[temp] >= 0)
                    numRay1[temp] = -numRay1[temp];
                else
                    Console.Write(Math.Abs(numRay1[i]) + " ");
            }

            ////Method-1 handle zero case also
            //for (int i = 0; i < numRay1.Length; i++)
            //{
            //    int temp = (numRay1[i] % 10);
            //    numRay1[temp] = numRay1[temp] + 10;
            //}
            //Console.WriteLine("The repeating elements are : ");
            //for (int i = 0; i < numRay1.Length; i++)
            //    if (numRay1[i] > 19)
            //        Console.WriteLine(i + " ");
        }

        private static void PrintFizzBuzzLogic(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void LongestRisingSequence()
        {
            int[] array = { 0, -100, 0, 1, -2, 3, 4, 10, -4, 3, 3, 2, 1, 2, 3, -1, 200, 305 };
            //{ -100, 0, 1, -2, 3, 4, 10, -4, 3, 3, 2, 1, 2, 3, -1, 200, 305 }

            Queue<int> queue = new Queue<int>();

            int currentMax = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < currentMax)
                {
                    queue.Enqueue(i);
                }
                currentMax = array[i];
            }

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + "  ");
            }

        }

        public static void ArrangeLinkedListAlternateOrder()
        {
            Console.WriteLine("Before Linked list is : ");
            List<int> listData = new List<int>();
            listData.Add(1);
            listData.Add(2);
            listData.Add(3);
            listData.Add(4);
            listData.Add(5);
            listData.Add(6);

            foreach (var item in listData)
            { Console.Write(item + " "); }

            List<int> NewList = new List<int>();

            int i = 0;
            while (listData.Count > 0)
            {
                if (i % 2 != 0)
                {
                    NewList.Add(listData.Last());
                    listData.Remove(listData.LastOrDefault());
                }
                else
                {
                    NewList.Add(listData.First());
                    listData.Remove(listData.FirstOrDefault());
                }
                i++;
            }

            Console.WriteLine("\nAfter Linked list is : ");
            foreach (var item in NewList)
            { Console.Write(item + " "); }

        }

        public static void FindMaxSubstringNonRepeatedChar(string str)
        {
            Console.WriteLine("Main string is : {0}", str);

            Dictionary<char, int> DictChar = new Dictionary<char, int>();


            int MaxLength = 0, index = 0; string MaxString = string.Empty;
            for (int i = 0; i < str.Length;)
            {
                if (DictChar.ContainsKey(str[i]))
                {
                    i = DictChar[str[i]] + 1;
                    index = DictChar.Count;
                    if (MaxLength < index)
                    {
                        MaxLength = DictChar.Count;
                        MaxString = string.Join("", DictChar.Select(x => x.Key).ToArray());
                    }
                    DictChar.Clear();
                }
                else
                {
                    DictChar.Add(str[i], i);
                    i++;
                }
            }


            Console.WriteLine("Length of the string :{0}, Max substring is :{1}", MaxLength, MaxString);

        }

        public static void FindColumnName(int number)
        {
            char[] Alphabhets = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                                 'Q','R','S','T','U','V','W','X','Y','Z' };
            string result = "";
            Stack<int> charNumber = new Stack<int>();

            if (number < 26)
            {
                Console.WriteLine(Alphabhets[number]);
                return;
            }
            int reminder = 0, divisor = number;
            while (divisor > 26)
            {
                reminder = divisor % 26;
                divisor = divisor / 26;
                if (reminder == 0)
                {
                    divisor = divisor - 1;
                    charNumber.Push(26);
                }
                else
                {
                    charNumber.Push(reminder);
                }

            }
            charNumber.Push(divisor);

            while (charNumber.Count > 0)
            {
                Console.Write(Alphabhets[charNumber.Pop() - 1]);
            }
            return;
        }

        public static int biggestSum(int[] arr)
        {
            int globalSum = arr[0], localSum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                localSum = Math.Max(arr[i], globalSum + arr[i]);
                globalSum = Math.Max(localSum, globalSum);
            }

            return globalSum;
        }

        public static void finalPrice(List<int> prices)
        {
            int sum = 0;
            //int index = 0;
            string noOutput = "";

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(prices[prices.Count - 1]);
            sum = sum + prices[prices.Count - 1];
            noOutput = noOutput + (prices.Count - 1) + " ";


            for (int i = prices.Count - 2; i >= 0; i--)
            {
                int firstmin = 0;
                while (queue.Count > 0)
                {
                    int temp = queue.Dequeue();
                    if (temp <= prices[i])
                    {
                        firstmin = temp;
                    }
                }
                if (firstmin < prices[i])
                {
                    sum = sum + (prices[i] - firstmin);
                }
                else
                {
                    sum = sum + (prices[i]);
                }

                if (firstmin <= 0)
                    noOutput = noOutput + (i) + " ";


                if (queue.Count <= 0)
                {
                    queue.Enqueue(prices[i]);
                }

            }

            char[] IndexOutput = noOutput.Trim().ToCharArray();
            Array.Reverse(IndexOutput);
            string temp1 = new string(IndexOutput);

            Console.WriteLine(sum);
            Console.WriteLine(temp1);

        }

        //public static void finalPrice(List<int> prices)
        //{
        //    int sum = 0;
        //    int index = 0;
        //    string noOutput = "";

        //    for (int i = 0; i < prices.Count - 1; i++)
        //    {
        //        int rightMin = prices[i];
        //        index = int.MaxValue;
        //        for (int j = i + 1; j < prices.Count; j++)
        //        {
        //            if (rightMin >= prices[j])
        //            {
        //                rightMin = prices[j];
        //                index = j;                        
        //            }
        //        }

        //        if (prices[i] == rightMin)
        //        {
        //            sum = sum + prices[i];
        //            if (index == int.MaxValue)
        //                noOutput = noOutput + i.ToString() + " ";
        //        }
        //        else
        //        {
        //            sum = sum + (prices[i] - rightMin);
        //        }

        //    }
        //    sum = sum + prices[prices.Count - 1];
        //    noOutput = noOutput + (prices.Count - 1).ToString();

        //    Console.WriteLine(sum);
        //    Console.WriteLine(noOutput.Trim());

        //}
    }

}
