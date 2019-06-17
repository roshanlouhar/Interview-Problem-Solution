using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructureLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region find greater element in array of current element and insert index at i th position in third array.
            //int[] array = { 4, 5, 8, 3, 7, 9 };
            //CheckNextGreaterElmentIndexInArray(array);
            #endregion

            #region  c# inbuilt data structure libraray for testing 
            int result = gcd(20, 5);
            Console.WriteLine(result + System.Environment.NewLine);
            #endregion

            #region  Binary Search using recursion
            //int[] array = { 4, 5, 8, 9, 17, 39 };
            //for (int c = 0; c < array.Length; c++)
            //{
            //    Console.Write(array[c] + "-" + array[c].GetHashCode() + "\t");                
            //}
            //BinarySearch(array, 8, 0, array.Length);
            #endregion

            #region  c# inbuilt data structure libraray for testing 
            //CheckDataStructureBuiltInCSharp();
            #endregion

            #region understand recursion sample
            //int result = CalFactorial(5);
            //int result = calculatePower(2, 3);
            //for (int c = 1; c <= 5; c++)
            //{
            //    Console.Write( CalFiabonic(c)+ "\t");
            //}
            //Console.WriteLine(result);
            #endregion

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();
        }
        
        public static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
        public static void BinarySearch(int[] array, int element, int low, int high)
        {
            int mid = ((low + high) / 2);
            if (array[mid] == element)
            {
                Console.WriteLine("\n" + "Element found at position {0}", mid + 1);
                //return 1;
            }
            else if (array[mid] < element)
            {
                BinarySearch(array, element, mid + 1, high);
            }
            else
            {
                BinarySearch(array, element, low, mid);
            }
            //return 0;
        }
        public static int CalFiabonic(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (CalFiabonic(n - 1) + CalFiabonic(n - 2));
        }
        public static int calculatePower(int number, int power)
        {
            if (power == 1 || power == 0)
                return number;

            return number * calculatePower(number, power - 1);
        }
        public static int CalFactorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;

            return 2 * CalFactorial(number - 1);
        }
        public static void CheckDataStructureBuiltInCSharp()
        {
            Dictionary<int, int> Dictionarylist = new Dictionary<int, int>();

            Stack<int> stacklist = new Stack<int>();

            Queue<int> queuelist = new Queue<int>();

            LinkedList<int> linkedlist = new LinkedList<int>();

            ArrayList arraylist = new ArrayList();

            SortedSet<int> sortedSet = new SortedSet<int>();

            SortedList<int, int> sortedlist = new SortedList<int, int>();

            SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();

            HashSet<int> hashSet = new HashSet<int>();

            Hashtable hashTable = new Hashtable();
            //hashTable.Add("A", "1");
            //hashTable.Add("B", "1");
            //hashTable.Add("C", "3");
            //hashTable.Add("D", "2");

            //Console.WriteLine(hashTable.Keys.Count);
            //Console.WriteLine(hashTable.Values.Count);


            //for (int i = 0; i < hashTable.Count; i++)
            //{
            //    Console.WriteLine(hashTable.ContainsValue(i.ToString()));
            //}


            Tuple<int, int, int, int> tupleList = new Tuple<int, int, int, int>(3, 4, 3, 4);


            //LinkedListNode<int> linkedlistNode = new 

        }
    }
}
