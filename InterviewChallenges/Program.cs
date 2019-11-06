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


            Console.ReadKey();
        }

        private static void LongestRisingSequence()
        {
            int[] array = {0, -100, 0, 1, -2, 3, 4, 10, -4, 3, 3, 2, 1, 2, 3, -1, 200, 305 };
            //{ -100, 0, 1, -2, 3, 4, 10, -4, 3, 3, 2, 1, 2, 3, -1, 200, 305 }

            Queue<int> queue = new Queue<int>();            

            int currentMax = array[0]; 
            
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < currentMax)
                {
                    queue.Enqueue(i);                    
                }
                currentMax = array[i];
            }

            while(queue.Count > 0)
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
