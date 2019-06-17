using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankInterviewProblems
{
    class Program
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int sum = 0;
            List<int> array = new List<int>();
            int count = 0; int first, second, third;
            int arrlength = 6; // arr.GetLength(1);
            for (int row = 0; row < (arrlength - 2); row++)
            {
                for (int col = 0; col < (arrlength - 2); col++)
                {
                    int temp = col; sum = 0;
                    for (first = col; first < (temp + 3); first++)
                    {
                        sum = sum + arr[row][first];
                    }

                    second = (col + first - 1) / 2;
                    sum = sum + arr[row + 1][second];

                    for (third = col; third < (temp + 3); third++)
                    {
                        sum = sum + arr[row + 2][third];
                    }
                    array.Add(sum);
                    count++;
                }
            }
            array.Sort();
            array.Reverse();
            int max = array[0];
            return max;
        }

        // Complete the rotLeft function below.
        static int[] RotLeft(int[] a, int d)
        {
            int i, j, k, temp;
            int n = a.Length;
            int test = gcd(d, n);
            for (i = 0; i < gcd(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = a[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    a[j] = a[k];
                    j = k;
                }
                a[j] = temp;
            }
            return a;

            //int arrlength = a.Length;
            //for (int i = 0; i < d; i++)
            //{
            //    Int64 temp = a[0];
            //    for (int l = 0; l < arrlength - 1; l++)
            //    {
            //        a[l] = a[l + 1];
            //    }
            //    a[arrlength-1] = temp;
            //}
            //return a;
        }

        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int ans = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                int temp = Math.Max(0, q[i] - 2);
                for (int j = temp; j < i; j++)
                    if (q[j] > q[i]) ans++;
            }
            Console.WriteLine(ans);
        }

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int result = 0; int valley = 0; bool IsEntered = false;

            char[] arrChar = s.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                if (arrChar[i] == 'D' && IsEntered == false && valley == 0)
                {
                    IsEntered = true;
                    valley++;
                }
                else if (arrChar[i] == 'D')
                {
                    valley++;
                }
                else if (arrChar[i] == 'U')
                {
                    valley--;
                }

                if (valley == 0 && IsEntered)
                {
                    result++;
                    IsEntered = false;
                }
            }
            return result;
        }

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int result = 0; bool flag = true;
            int length = c.Length, current = 0, next1 = 0, Next2 = 0;

            for (int i = 0; i < length; i++)
            {
                int j = i;
                if ((i + 2) < length)
                {
                    current = c[i]; next1 = c[i + 1]; Next2 = c[i + 2];
                    if (current != 1 && next1 == 0 && Next2 == 0)
                    {
                        i = i + 1;
                        result++;
                    }
                    else
                    {
                        if (next1 == 0)
                        {
                            //i = i + 1;
                            result++;
                        }
                    }
                }
                else if ((i + 1) < length)
                {
                    current = c[i]; next1 = c[i + 1];
                    if (next1 == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long result = 0;
            char[] str = s.ToCharArray();

            int strlength = str.Length;
            long StringLoop = (n / strlength);
            long RemainingLoop = n % strlength;

            long noOfA = 0;
            for (int i = 0; i < strlength; i++)
            {
                if (str[i] == 'a')
                {
                    noOfA++;
                }
            }
            result = noOfA * StringLoop;
            for (int i = 0; i < RemainingLoop; i++)
            {
                if (str[i] == 'a')
                {
                    result++;
                }
            }

            return result;
        }

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            int row = queries.GetLength(0);
            //int col = queries.GetLength(1);

            long[] array = new long[n + 1];
            long TempMax = 0, max = 0;

            for (int i = 0; i < row; i++)
            {
                int a = Convert.ToInt32(queries[i][0]);
                int b = Convert.ToInt32(queries[i][1]);
                long k = long.Parse(queries[i][2].ToString());

                array[a] += k;
                if (b + 1 <= n)
                    array[b + 1] -= k;

                //for (int j = a; j <= b; j++)
                //{
                //    array[j] += k;
                //    TempMax = array[j];
                //    if (TempMax > max)
                //        max = TempMax;
                //}
            }

            long tempMax = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += array[i];
                if (tempMax > max) max = tempMax;
            }

            return max;
        }

        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int first = 0, last = arr.Length - 1;
            int swaps = 0;
            while (first < last)
            {
                while (arr[first] == first + 1 && first < last)
                    first++;
                if (first < last)
                {
                    int temp = arr[arr[first] - 1];
                    arr[arr[first] - 1] = arr[first];
                    arr[first] = temp;
                    swaps++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return swaps;
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            // Complete this function  
            int count = 0;
            Dictionary<string, int> keyValues = new Dictionary<string, int>();

            for (int i = 0; i < ar.Length; i++)
            {
                string tempKey = Convert.ToString(ar[i]).Trim();
                if (!keyValues.ContainsKey(tempKey))
                {
                    keyValues.Add(tempKey, 1);
                }
                else
                {
                    keyValues[tempKey]++;
                }
                if ((keyValues[tempKey] % 2) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            int count = 0, sum = 0;
            int len = prices.Length;

            //for (int i = 0; i < len - 1; i++)
            //{
            //    for (int j = 0; j < len - 1; j++)
            //    {
            //        if (prices[j] > prices[j + 1])
            //        {
            //            int tempValue = prices[j];
            //            prices[j] = prices[j + 1];
            //            prices[j + 1] = tempValue;
            //        }
            //    }
            //}

            Array.Sort(prices);

            for (int j = 0; j < len - 1; j++)
            {
                sum = sum + prices[j];
                if (sum <= k)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static int activityNotifications(int[] expenditure, int d)
        {
            var ret = 0;
            var mid = d / 2;
            var even = d % 2 == 0;
            var arr = expenditure.Take(d).OrderBy(i => i).ToList();

            for (var i = d; i < expenditure.Length; i++)
            {
                var exp = expenditure[i];
                var old = expenditure[i - d];

                if (exp >= (even ? arr[mid - 1] + arr[mid] : arr[mid] * 2))
                {
                    ret++;
                }
                if (exp != old)
                {
                    arr.RemoveAt(arr.BinarySearch(old));
                    var newIdx = arr.BinarySearch(exp);
                    arr.Insert(newIdx < 0 ? ~newIdx : newIdx, exp);
                }
            }
            return ret;
        }

        // Complete the activityNotifications function below.
        //static int activityNotifications(int[] expenditure, int d)
        //{
        //    float median = 0; int count = 0; bool isfirst = true;
        //    float sum = 0; int next = 0, prev = 0;

        //    for (int i = 0; i < d; i++)
        //    {
        //        sum += expenditure[i];
        //    }
        //    Console.WriteLine((expenditure.Length - d));        

        //    for (int i = 0; i < (expenditure.Length - d); i++)
        //    {
        //        if (isfirst)
        //        {
        //            isfirst = false;
        //        }
        //        else
        //        {
        //            next = expenditure[i - 1];
        //            prev = expenditure[d + i - 1];
        //            sum = (sum + prev) - next;
        //        }
        //        median = sum / d;            

        //        if (expenditure[d + i] >= 2 * median)
        //        {
        //            //Console.WriteLine(median + "=" + sum + "/" + d);

        //            //Console.WriteLine(expenditure[d + i] + "-" + 2 * median);

        //            count++;
        //        }
        //    }
        //    return count;
        //}

        // Complete the countInversions function below.
        static long countInversions(int[] arr)
        {
            long result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        result++;
                    }
                }
            }
            return result;
        }

        // Complete the makeAnagram function below.
        static int makeAnagram(string a, string b)
        {
            int result = 0;

            int[] lettercounts = new int[26];
            foreach (char c in a.ToCharArray())
            {
                lettercounts[c - 'a']++;
            }
            foreach (char c in b.ToCharArray())
            {
                lettercounts[c - 'a']--;
            }

            foreach (int i in lettercounts)
            {
                result += Math.Abs(i);
            }


            //Dictionary<string, int> first = new Dictionary<string, int>();
            //Dictionary<char, int> test = new Dictionary<char, int>();
            //foreach (char c in a.ToCharArray())
            //{
            //    if (!test.ContainsKey(c))
            //        test[c] = 1;
            //    else
            //        test[c]++;
            //}

            //foreach (char c in b.ToCharArray())
            //{
            //    if (!test.ContainsKey(c))
            //        test[c] = 1;
            //    else
            //        test[c]--;
            //}

            //foreach (var c in test)
            //{
            //    if(c.Value >= 0)
            //        result = result + Math.Abs(c.Value);
            //}


            return result;

        }

        // Complete the alternatingCharacters function below.
        static int alternatingCharacters(string s)
        {
            int result = 0;
            var array = s.ToList();

            for (int i = 0; i < array.Count - 1;)
            {
                if (array[i] == array[i + 1])
                {
                    array.Remove(array[i + 1]);
                    result++;
                }
                else
                    i++;
            }
            return result;
        }

        // Complete the substrCount function below.    
        public static long substrCount(int length, String s)
        {
            long counter = 0;
            for (int i = 0; i < length; i++)
            {
                // if the current symbol is in the middle of palindrome, e.g. aba
                int offset = 1;
                while (i - offset >= 0 && i + offset < length && s[i - offset] == s[i - 1]
                        && s[i + offset] == s[i - 1])
                {
                    counter++;
                    offset++;
                }
                // if this is repeatable characters aa
                int repeats = 0;
                while (i + 1 < length && s[i] == s[i + 1])
                {
                    repeats++;
                    i++;
                }
                counter += repeats * (repeats + 1) / 2;
            }
            return counter + length;
        }

        static int commonChild(String s1, String s2)
        {
            int[] a = new int[s2.Length + 1];

            foreach (char c in s1.ToCharArray())
            {
                int prev = 0;

                for (int i = 0; i < s2.Length; i++)
                {
                    int temp = a[i + 1];

                    if (s2[i] == c)
                    {
                        a[i + 1] = Math.Max(prev + 1, a[i + 1]);
                    }
                    else
                    {
                        a[i + 1] = Math.Max(a[i], a[i + 1]);
                    }

                    prev = temp;
                }
            }

            return a[a.Length - 1];
        }

        // Complete the isValid function below.
        static string isValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "NO";
            if (s.Length <= 3)
                return "YES";

            string result = "NO";
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
            }
            int min = 0, max = 0;

            Array.Sort(arr);


            int k = 0;
            while (arr[k] == 0)
            {
                k++;
            }

            //System.out.println(Arrays.toString(letters));
            min = arr[k];   //the smallest frequency of some letter
            max = arr[25]; // the largest frequency of some letter

            if (min == max) result = "YES";
            else
            {
                // remove one letter at higher frequency or the lower frequency 
                if (((max - min == 1) && (max > arr[24])) ||
                    (min == 1) && (arr[k + 1] == max))
                    result = "YES";
            }

            return result;
        }

        // Complete the whatFlavors function below.
        static void whatFlavors(int[] cost, int money)
        {
            int arrSize = cost.Length;
            var map = new Dictionary<int, int>();

            for (int i = 0; i < cost.Length; i++)
            {
                int diff = money - cost[i];
                if (map.ContainsKey(cost[i]))
                {
                    int id1 = i + 1;
                    int id2 = map[cost[i]];

                    Console.WriteLine(Math.Min(id1, id2) + " " + Math.Max(id1, id2));
                    break;
                }
                else
                {
                    int key = money - cost[i];
                    int value = i + 1;
                    map.Add(key, value);
                }
            }

        }

        static int FootballTrainingTime(int[] arr, int NoOfPlayer)
        {
            double result = 0;
            int index = 0, FixPoint = 0;

            Array.Sort(arr);
            var temp = arr.GroupBy(x => x);

            // directly found player without doing training
            int Res = temp.Where(x => x.Count() == NoOfPlayer).Count();
            if (Res > 0)
            { return 0; }

            // finding avg of element and min and max near to avg.
            double ArrAvg = Math.Ceiling(arr.Average());
            double min = arr.Where(x => (x < ArrAvg)).LastOrDefault();
            double max = arr.Where(x => (x > ArrAvg)).FirstOrDefault();

            //finding diff between avg to min/max values.
            double maxDiff = max - ArrAvg;
            double mindiff = ArrAvg - min;

            //checking any elment nearly to avg where need lesser training count
            int MaxElementCount = temp.Max(x => x.Count());
            int MaxElementNumber = 0;
            if (MaxElementCount > 1)
            {
                MaxElementNumber = temp.Where(x => x.Count() == MaxElementCount).Select(x => x.Key).FirstOrDefault();
                FixPoint = MaxElementNumber;
                index = Array.IndexOf(arr, FixPoint);
            }
            else
            {
                if (maxDiff > mindiff)
                {
                    string s = min.ToString();
                    FixPoint = int.Parse(s);
                    index = Array.IndexOf(arr, FixPoint);
                }
                else
                {
                    string s = max.ToString();
                    FixPoint = int.Parse(s);

                    index = Array.IndexOf(arr, FixPoint);
                }
            }

            int count = 1;
            NoOfPlayer = NoOfPlayer - MaxElementCount;
            for (int i = index - 1; i >= 0; i--)
            {
                if (count == NoOfPlayer)
                    break;

                double diff = (FixPoint - arr[i]);
                if (diff <= 0)
                    break;
                else
                    result = result + diff;
                count++;
            }


            return int.Parse(result.ToString());
        }

        //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int[] cellCompete(int[] states, int days)
        {
            int[] temp = new int[states.Length];

            int left = 0, right = 0, result = 0;

            // INSERT YOUR CODE HERE
            for (int day = 1; day <= days; day++)
            {
                temp[0] = 0 ^ states[1];
                temp[states.Length - 1] = 0 ^ states[states.Length - 2];

                for (int l = 1; l <= states.Length - 2; l++)
                {
                    left = states[l + 1];
                    right = states[l - 1];

                    result = left ^ right;
                    temp[l] = result;
                }
                temp.CopyTo(states, 0);
            }

            return states;
        }

        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED

        public static int generalizedGCD(int num, int[] arr)
        {
            // WRITE YOUR CODE HERE
            Array.Sort(arr);
            int min = arr[0];
            int max = arr[num - 1];
            int result = 0;

            int count = num;
            while (max > min && count >= 0)
            {
                int temp = max % min;
                if (temp == 0)
                {
                    count--;
                    max = arr[count];
                }
                else
                {
                    result = 1;
                    break;
                }
            }
            if (count == 0)
                result = min;

            return result;
        }

        public static int minimumTime(int numOfSubFiles, int[] files)
        {
            // WRITE YOUR CODE HERE
            int result = 0;
            int[] temp = new int[numOfSubFiles];

            Array.Sort(files);

            //SortedSet<int> list = new SortedSet<int>();
            //foreach(int obj in files)
            //{
            //    list.Add(obj);
            //}

            int min = 0;
            int max = numOfSubFiles - 1;

            int count = 0;
            while (max > min)
            {
                int first = files[min];
                int second = files[min + 1];
                int sum = first + second;

                files[min] = 0;
                files[min + 1] = sum;
                min++;

                Array.Sort(files);

                temp[count] = sum;
                count++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                result = result + temp[i];
            }
            return result;
        }

        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int getMinimumCostToConstruct(int numTotalAvailableCities,
                                             int numTotalAvailableRoads,
                                             int[,] roadsAvailable,
                                             int numNewRoadsConstruct,
                                             int[,] costNewRoadsConstruct)
        {
            int result = 0;
            int ralength = roadsAvailable.GetLength(0);
            int cnrLength = costNewRoadsConstruct.GetLength(0);

            Dictionary<int, bool> listCity = new Dictionary<int, bool>();
            for (int i = 0; i < numTotalAvailableCities; i++)
            {
                listCity.Add(i + 1, false);
            }
            List<Edge> availableListEdge = new List<Edge>();
            List<Edge> NewConstructlistEdge = new List<Edge>();
            List<List<int>> DistinctNetwork = new List<List<int>>();

            //int[,] graph = new int[numTotalAvailableCities, numTotalAvailableCities];

            for (int i = 0; i < ralength; i++)
            {
                int city1 = roadsAvailable[i, 0];
                int city2 = roadsAvailable[i, 1];
                availableListEdge.Add(new Edge(city1, city2, 0));
                //graph[city1 - 1, city2 - 1] = 1;
                //graph[city2 - 1, city1 - 1] = 1;
            }


            for (int c = 0; c < cnrLength; c++)
            {
                int city1 = costNewRoadsConstruct[c, 0];
                int city2 = costNewRoadsConstruct[c, 1];
                int cost = costNewRoadsConstruct[c, 2];
                NewConstructlistEdge.Add(new Edge(city1, city2, cost));
            }

            for (int i = 1; i <= numTotalAvailableCities; i++)
            {
                bool flag = true;
                int city = i;

                while (flag)
                {
                    var connEdge = availableListEdge.Where(x => x.source == city).ToList();
                    if (connEdge.Count > 0)
                    {
                        city = connEdge.FirstOrDefault().destination;
                        availableListEdge.Remove(connEdge.FirstOrDefault());
                        flag = true;
                    }
                    else
                    {
                        var ConstrEdges = NewConstructlistEdge.Where(x => (x.destination == city + 1 || x.source == i - 1)).ToList();
                        int minCostEdge = ConstrEdges.Count > 0 ? ConstrEdges.Min(x => x.weight) : 0;
                        result = result + minCostEdge;
                        flag = false;
                        foreach (var edge in ConstrEdges)
                        {
                            NewConstructlistEdge.Remove(edge);
                        }
                    }
                }
            }

            //findcost(numTotalAvailableCities, graph);
            return result;
        }

        public static bool IsConnectedEdge(int n, int[][] graph)
        {
            bool result = false;

            return result;
        }

        // Function to find out minimum valued node 
        // among the nodes which are not yet included in MST 
        public static int minnode(int n, int[] keyval, bool[] mstset)
        {
            int mini = int.MaxValue;
            int mini_index = 0;

            // Loop through all the values of the nodes 
            // which are not yet included in MST and find 
            // the minimum valued one. 
            for (int i = 0; i < n; i++)
            {
                if (mstset[i] == false && keyval[i] < mini)
                {
                    mini = keyval[i];
                    mini_index = i;
                }
            }
            return mini_index;
        }

        // Function to find out the MST and 
        // the cost of the MST. 
        public static void findcost(int n, int[,] city)
        {

            // Array to store the parent node of a 
            // particular node. 
            int[] parent = new int[n];

            // Array to store key value of each node. 
            int[] keyval = new int[n];

            // Boolean Array to hold bool values whether 
            // a node is included in MST or not. 
            bool[] mstset = new bool[n];

            // Set all the key values to infinite and 
            // none of the nodes is included in MST. 
            for (int i = 0; i < n; i++)
            {
                keyval[i] = int.MaxValue;
                mstset[i] = false;
            }

            // Start to find the MST from node 0. 
            // Parent of node 0 is none so set -1. 
            // key value or minimum cost to reach 
            // 0th node from 0th node is 0. 
            parent[0] = -1;
            keyval[0] = 0;

            // Find the rest n-1 nodes of MST. 
            for (int i = 0; i < n - 1; i++)
            {

                // First find out the minimum node 
                // among the nodes which are not yet 
                // included in MST. 
                int u = minnode(n, keyval, mstset);

                // Now the uth node is included in MST. 
                mstset[u] = true;

                // Update the values of neighbor 
                // nodes of u which are not yet 
                // included in MST. 
                for (int v = 0; v < n; v++)
                {

                    if (city[u, v] > 0 && mstset[v] == false && city[u, v] < keyval[v])
                    {
                        keyval[v] = city[u, v];
                        parent[v] = u;
                    }
                }
            }

            // Find out the cost by adding 
            // the edge values of MST. 
            int cost = 0;
            for (int i = 1; i < n; i++)
                cost += city[parent[i], i];

            Console.WriteLine(cost);
        }
        public static void CheckNextGreaterElmentIndexInArray(int[] array)
        {
            int[] indexArr = new int[array.Length];
            Console.Write("Before " + System.Environment.NewLine);

            Dictionary<int, int> list = new Dictionary<int, int>();
            Stack<int> stacklist = new Stack<int>();

            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i], i);
                Console.Write("\t" + array[i]);
            }

            //stacklist.Push(array[0]);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                //Using the stack and Dictionary Time complexity will be for worse case and best case will be O(n + K)
                while (stacklist.Count > 0 && array[i] > stacklist.Peek())
                {
                    stacklist.Pop();
                }
                if (stacklist.Count == 0)
                    indexArr[i] = -1;
                else
                    indexArr[i] = list[stacklist.Peek()];

                stacklist.Push(array[i]);

                //Using the two loops Time complexity will be O(n^2)
                //while (j < array.Length)
                //{
                //    if (array[i] < array[j])
                //    {
                //        indexArr[i] = j;
                //        break;
                //    }
                //    j++;
                //}
                //if (j == array.Length)
                //{
                //    indexArr[i] = -1;
                //}
            }

            Console.WriteLine(System.Environment.NewLine + "After ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t" + indexArr[i]);
            }
        }
        // Complete the stepPerms function below.
        public static int stepPerms(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            if (n == 3)
                return 4;
            return stepPerms(n - 1) + stepPerms(n - 2) + stepPerms(n - 3);

        }
        // Complete the crosswordPuzzle function below.
        public static string[] crosswordPuzzle(string[] crossword, string words)
        {
            int rows = 10, cols = 10;
            string[] resultArray = new string[rows];
            char[,] ArrayFeed = new char[10, 10];

            string[] wordArray = words.Split(';');

            for (int i = 0; i < rows; i++)
            {
                char[] temp = crossword[i].ToCharArray();
                for (int j = 0; j < cols; j++)
                {
                    ArrayFeed[i, j] = temp[j];
                }
            }

            //horizontal
            for (int i = 0; i < rows; i++)
            {
                int isSpace = crossword[i].IndexOf('-');
                int verticalspace = 1;
                int horizontalSpace = 1;

                //checking rows wise
                for (int j = isSpace + 1; j < rows; j++)
                {
                    if (ArrayFeed[i, j] != '+')
                        horizontalSpace++;
                }

                //checking col wise
                for (int j = isSpace + 1; j < rows; j++)
                {
                    if (ArrayFeed[j, i] != '+')
                        verticalspace++;
                }

                if (verticalspace > horizontalSpace)
                {
                    wordArray.Where(x => (x.Length == verticalspace || x.Length == horizontalSpace));
                }
                else
                {

                }

            }

            //Vertical




            return resultArray;
        }

        // Complete the superDigit function below.
        static string superDigit(string n)
        {
            if (n.Length == 1)
                return n;
            return superDigit(SumDigits(n).ToString());

        }
        public static Int64 SumDigits(string n)
        {
            long sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i] - '0';
            }
            return sum;
        }

        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            Stack<char> obj = new Stack<char>();
            char[] CharArr = s.ToCharArray();
            for (int i = 0; i < CharArr.Length; i++)
            {
                if (CharArr[i] == '(' || CharArr[i] == '{' || CharArr[i] == '[')
                {
                    obj.Push(CharArr[i]);
                }
                else if ((CharArr[i] == ')' || CharArr[i] == '}' || CharArr[i] == ']') && obj.Count > 0)
                {
                    var temp = obj.Pop();

                    if ((CharArr[i] == ')' && temp != '('))
                        return "NO";
                    if ((CharArr[i] == '}' && temp != '{'))
                        return "NO";
                    if ((CharArr[i] == ']' && temp != '['))
                        return "NO";
                }
                else
                {
                    return "NO";
                }
            }

            if (obj.Count > 0)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
        // Complete the largestRectangle function below.
        static long largestRectangle(int[] h)
        {
            long result = 0;
            long Max = 0;
            //SortedSet<int> sortedlist = new SortedSet<int>();
            Stack<long> StackObj = new Stack<long>();
            //Array.Sort(h);

            for (int i = 0; i < h.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < h.Length; j++)
                {
                    if (h[i] <= h[j])
                    { count++; continue; }
                    else
                    { break; }
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    if (h[i] <= h[k])
                    { count++; continue; }
                    else
                    { break; }
                }

                long area = h[i] * count;
                StackObj.Push(area);

                //sortedlist.Add(item);
            }
            result = StackObj.Max();
            return result;
        }
        public static string GetEvenOdd(string str)
        {
            int i = 0;
            string EvenString = "", OddString = "";
            while (i < str.Length)
            {
                if (i % 2 == 0)
                {
                    EvenString = EvenString + str[i];
                }
                else
                {
                    OddString = OddString + str[i];
                }
                i++;
            }
            string result = EvenString + " " + OddString;
            return result;
        }
        // Complete the riddle function below.
        static long[] riddle(long[] arr)
        {
            // complete this function
            long[] result = new long[arr.Length];
            int n = arr.Length;

            long max = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            result[0] = max;
            for (int window = 2; window <= n; window++)
            {
                Queue<long> tempStack = new Queue<long>();

                int span = 0;

                int loop = n - window + 1;
                while (span < loop)
                {
                    long[] tempArr = new long[loop];
                    //Array.Copy(arr, tempArr,);
                    long min = arr[span];
                    int i = span;
                    while (i < (window + span))
                    {
                        if (arr[i] < min)
                            min = arr[i];
                        i++;
                    }
                    span++;
                    tempStack.Enqueue(min);
                }
                result[window - 1] = tempStack.Max();
            }
            return result;
        }

        static long[] riddleOptimized(long[] arr)
        {
            // complete this function
            long[] result = new long[arr.Length];
            int n = arr.Length;

            long max = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            result[0] = max;
            for (int window = 2; window <= n; window++)
            {
                Queue<long> tempStack = new Queue<long>();

                int span = 0;

                int loop = n - window + 1;
                while (span < loop)
                {
                    long[] tempArr = new long[loop];
                    long min = arr[span];
                    int i = span;
                    while (i < (window + span))
                    {
                        if (arr[i] < min)
                            min = arr[i];
                        i++;
                    }
                    span++;
                    tempStack.Enqueue(min);
                }
                result[window - 1] = tempStack.Max();
            }
            return result;
        }

        static void Main(string[] args)
        {

            #region 2d array max sum
            //int[][] arr = new int[6][];
            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = new int[6];
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (i == j)
            //        {
            //            arr[i][j] = 0;
            //        }
            //        else
            //        {
            //            int t = -i + (-j);
            //            if (t > 9 && t < -9)
            //                t = 0;
            //            arr[i][j] = t;                    
            //        }
            //    }
            //}
            //int result = hourglassSum(arr);
            //Console.WriteLine("Result is " + result);
            #endregion

            #region rotate array
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //int d = 3;
            //int[] result = RotLeft(a, d);
            #endregion

            #region Fins minnimum bribe
            //int[] a = { 2, 1, 5, 3, 4 };

            //minimumBribes(a);
            #endregion

            #region counting Valleys
            //int n = 12;

            //string s = "DDUUDDUDUUUD";

            //int result = countingValleys(n, s);

            //Console.WriteLine(result);
            #endregion

            #region jumping On Clouds       

            //int[] a = { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 };

            //int result = jumpingOnClouds(a);

            //Console.WriteLine(result);
            #endregion

            #region repeated String function       

            //string s = Console.ReadLine();

            //long n = Convert.ToInt64(Console.ReadLine());

            //long result = repeatedString(s, n);

            //Console.WriteLine(result);

            #endregion

            #region repeated String function  
            //string[] nm = Console.ReadLine().Split(' ');

            //int n = Convert.ToInt32(nm[0]);
            //int m = Convert.ToInt32(nm[1]);


            //int[][] query = new int[m][];

            //for (int i = 0; i < m; i++)
            //{
            //    query[i] = new int[3];
            //    string[] opString = Console.ReadLine().Split(' ');
            //    int a = int.Parse(opString[0]);
            //    int b = int.Parse(opString[1]);
            //    int k = int.Parse(opString[2]);

            //    query[i][0] = a;
            //    query[i][1] = b;
            //    query[i][2] = k;
            //}

            //long result = arrayManipulation(n, query);

            //Console.WriteLine(result.ToString());
            #endregion

            #region mininmum swaps
            //int[] a = { 1, 3, 5, 2, 4, 6, 7 };

            //int result = minimumSwaps(a);

            //Console.WriteLine(result);
            #endregion

            #region Number of paired socks
            //int[] a = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

            //int result = sockMerchant(a.Length, a);

            //Console.WriteLine(result);
            #endregion

            #region Maximum toys

            //string test = "2716485 47574329 54317443 73887797 4690442 50158330 36082844 35504863 10098449 36757751 51223808 70905600 2915719 19449463 15531534 90627969 10138256 56422983 94058705 61663313 49377065 49952346 67204721 50973358 35007152 35561646 21839119 62717102 25604425 42393960 26469586 28320910 89968289 33303381 54725059 94658731 83461711 90807903 82679946 46076512 80082006 33903754 69498465 82997725 5869569 85029999 73625694 16007825 41452983 20200751 77671138 43346400 70153097 44875859 46836111 57676602 32953858 68675230 20393704 11074635 63585542 99379642 91911897 6070183 85199375 46636956 53245266 21177439 37444859 35925213 19770303 70043217 69828967 89268768 53040943 75698537 74298768 79182989 44222714 68268103 51900093 21893853 64130855 22053190 19286064 10966966 32246144 52239922 32158548 5156201 15830909 48260442 57052195 7742806 54330625 42251571 54379762 7575892 15945362 44340973 96017457 35715665 14384191 65846424 77500786 19941486 94061313 4315906 51640827 38284028 72584009 3540920 12694233 89231216 78110463 31980297 52714535 10356607 36736572 84873083 68029160 52567481 85649878 25081356 60310288 39980503 19849279 67206402 72747 88310993 11547376 96090204 76543010 78447919 14452981 54043796 50905757 8514294 58359702 2546584 99314674 83460063 6087505 12008907 72691280 84197968 96505557 25405815 47070927 85758481 62795250 67616440 90842314 961480 92697796 3668954 40941984 65063427 70875357 93531083 53374420 34939085 89621288 29917430 65903356 4074269 36477579 16809113 65104915 94837281 19355697 16935942 78297345 77959554 81461201 3504977 14673874 77966758 81427144 61744802 16241591 96738746 81877594 7083906 97700227 74575390 10752860 91158563 92155169 81628217 84689646 45529589 69083654 26827286 27963371 34987010 83417907 64440950 51796123 823";

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            //int result = maximumToys(a, 80000000);

            //Console.WriteLine(result);
            #endregion

            #region activity Notifications

            //var test = "2 3 4 2 3 6 8 4 5";

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            ////Console.WriteLine(a.Length);

            //int result = activityNotifications(a, 5);

            //Console.WriteLine(result);
            #endregion

            #region count Inversions 

            //var test = "2 1 3 1 2";

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            ////Console.WriteLine(a.Length);

            //long result = countInversions(a);

            //Console.WriteLine(result);
            #endregion

            #region make Anagram 
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //int result = makeAnagram(a, b);
            //Console.WriteLine(result);
            #endregion

            #region alternating Characters
            //string a = Console.ReadLine();
            //int result = alternatingCharacters(a);
            //Console.WriteLine(result);
            #endregion

            #region find special palindrone
            //string a = Console.ReadLine();
            //long result = substrCount(a.Length , a);
            //Console.WriteLine(result);
            #endregion

            #region Common child
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //long result = commonChild(a, b);
            //Console.WriteLine(result);
            #endregion

            #region Sherlock and the Valid String
            //string a = Console.ReadLine();
            //string result = isValid(a);
            //Console.WriteLine(result);
            #endregion

            #region  Ice Cream Parlor
            //var test = "2 1 4 3";
            //int money = 4;
            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            //whatFlavors(a, money);
            #endregion

            #region  football Traing Time
            //var test = "7 6 1 7 7";
            //int noOfPlayers = 5;

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            //long result = FootballTrainingTime(a, noOfPlayers);

            //Console.WriteLine(result);
            #endregion

            #region amazon  cell Compete
            //var test = "1 0 0 0 0 1 0 0";

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            //int[] result = cellCompete(a, 1);
            #endregion

            #region amazon Generalized GCD
            //var test = "2 3 4 5 6";

            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            //int result = generalizedGCD(a.Length, a);
            #endregion

            #region Amazon Media Encoder
            //var test = "8 4 6 12";
            //int[] a = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            //int numOfSubFiles = a.Length;

            //int result = minimumTime(numOfSubFiles, a);
            #endregion

            #region Amazon logistics system design
            //int numTotalAvailableCities = 6;
            //int numTotalAvailableRoads = 3;
            //int[,] roadsAvailable = { { 1, 4 }, { 4, 5 }, { 2, 3 } }; ;
            //int numNewRoadsConstruct = 4;
            //int[,] costNewRoadsConstruct = { { 1, 2, 5 }, { 1, 3, 10 }, { 1, 6, 7 }, { 5, 6, 5 } };

            //int result = getMinimumCostToConstruct(numTotalAvailableCities, numTotalAvailableRoads, roadsAvailable,
            //    numNewRoadsConstruct, costNewRoadsConstruct);

            //Console.WriteLine(result);
            #endregion

            #region find greater element in array of current element and insert index at i th position in third array.
            //int[] array = { 4, 5, 8, 3, 7, 9 };
            //CheckNextGreaterElmentIndexInArray(array);
            #endregion

            #region check number of step using recusrion.
            //int n = 5;
            //int result = stepPerms(n);
            //Console.WriteLine(result);
            #endregion

            #region crossword puzzzle solution.
            //string[] crossword = { "+-++++++++","+-++++++++","+-++++++++","+-----++++","+-+++-++++"
            //                       ,"+-+++-++++","+++++-++++","++------++","+++++-++++","+++++-++++" };

            //string word = "LONDON;DELHI;ICELAND;ANKARA";
            //var result = crosswordPuzzle(crossword, word);
            //Console.WriteLine(result);
            #endregion

            #region finding super digits
            //string n = "593";
            //int k = 10;
            //Console.WriteLine(superDigit((SumDigits(n) * k).ToString()));
            #endregion

            #region finding expression is balanced or not       
            //string n = "}][}}(}][))]";
            //string result = isBalanced(n);
            //Console.WriteLine(result);
            #endregion

            #region Complete the largestRectangle function below.
            //string test = "8979 4570 6436 5083 7780 3269 5400 7579 2324 2116";
            //int[] array = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            //long result = largestRectangle(array);
            //Console.WriteLine();
            #endregion

            #region get even and odd result of the string
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string str = Convert.ToString(Console.ReadLine());
            //    if (!string.IsNullOrEmpty(str))
            //    {
            //        string result = GetEvenOdd(str);
            //        Console.WriteLine(result);
            //    }
            //}
            #endregion

            #region Complete the largestRectangle optimized function below.
            //string test = "1 2 3 5 1 13 3";
            //long[] array = Array.ConvertAll(test.Split(' '), pricesTemp => Convert.ToInt64(pricesTemp));
            //long[] result = riddleOptimized(array);
            //Console.WriteLine(array.ToString());
            #endregion



            Console.ReadKey();

        }
    }

    public class Edge
    {
        public int source, destination, weight;
        public Edge(int source, int destination, int weight)
        {
            this.source = source;
            this.destination = destination;
            this.weight = weight;
        }
    }
}
