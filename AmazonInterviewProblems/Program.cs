using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterviewProblems
{
    class Program
    {

        static int NO_OF_CHARS = 256;
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            //Console.WriteLine("\n Checking Anagram.");
            //char[] str1 = ("tests").ToCharArray();
            //char[] str2 = ("tests").ToCharArray();
            //bool result = obj.CheckAnagramCountCharMethod(str1, str2);

            // create and initalize new ArrayList 
            ArrayList str1 = new ArrayList();
            //str1.Add('t');
            //str1.Add('e');
            //str1.Add('s');
            //str1.Add('t');
            // create and initalize new ArrayList 
            ArrayList str2 = new ArrayList();
            //str2.Add('t');
            //str2.Add('e');
            //str2.Add('s');
            //str2.Add('t');
            bool result = CheckAnagramSortMethod(str1, str2);
            //if (result)
            //    Console.WriteLine("Strings is anagram");
            //else
            //    Console.WriteLine("Strings is not anagram");

            //...............................
            ReverseWordOrder("Strings is not anagram");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
                
        //Find if two given strings are anagrams of each other or not.Anagrams example: LISTEN and SILENT.
        // Code for the same. Test cases for the code. (Positive and negative)
        // They called me to Hyderabad for an F2F immediately after Skpe rounds, (I managed to postpone it to the next week).
        public static bool CheckAnagramCountCharMethod(char[] str1, char[] str2)
        {

            // Create 2 count arrays and initialize 
            // all values as 0 
            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];
            int i;

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array 
            for (i = 0; i < str1.Length && i < str2.Length;
                 i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }

            // If both strings are of different length. 
            // Removing this condition will make the program 
            // fail for strings like "aaca" and "aca" 
            if (str1.Length != str2.Length)
                return false;

            // Compare count arrays 
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;

        }

        public static bool CheckAnagramSortMethod(ArrayList str1, ArrayList str2)
        {
            // Get lenghts of both strings 
            int n1 = str1.Count;
            int n2 = str2.Count;

            // If length of both strings is not 
            // same, then they cannot be anagram 
            if (n1 != n2)
            {
                return false;
            }

            // Sort both strings 
            str1.Sort();
            str2.Sort();

            // Compare sorted strings 
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }

        //Print a tree in zigzag order. For Example for the given input tree:-
        //        1
        //    2        3
        //4        5 6        7
        //The output would be:-
        //1
        //3 2
        //4 5 6 7
        public static void PrintATreeInZigZagOrder(int[] arr)
        {

        }

        //Given a character array which each position is filled with either a single digit numbers or a comma,
        //Array of 22 characters:-
        //Write a code to reply true if we find a set of three set of numbers separated by a comma such that
        //X, Y, Z and Z = X + Y .In the array above 77+22 = 99 so return true.Code for the same with negative test cases.
        public static bool CheckThreeSetOfNumberCOmmaSeperated(int[] arr)
        {

            return true;
        }

        //If in a given Doubly Circular Linked List a couple of next pointers are corrupted, give the logic to rectify them all.
        public static bool RectifyBrokenLinkList(int[] arr)
        {

            return true;
        }

        //Given a number in an int variable, write a code print its value in words, covering all possible corner cases.
        //Ex → 34567 = thirty four thousand five hundred and sixty seven.  Negative test cases for the same.
        public bool PrintNumberInWords(int[] arr)
        {

            return true;
        }
        
        //Given a scheduler arrangement with some jobs having unique job ids and every job id has a number of tasks with unique task ids for that job.
        //Example:- 
        // Job id : 500    Task id : 700
        //      Task id : 300
        //      Task id : 350
        // Job id : 600    Task id : 400
        //      Task id : 350
        //      Task id : 600
        // Job id : 1000    Task id : 800
        //      Task id : 100
        // Job id : 200    Task id : 650
        //Write a Code for listing the job ids + task id combination in round robin fashion.
        //Example:- 
        //Job id : 500    Task id : 700
        //Job id : 600    Task id : 400
        //Job id : 1000    Task id : 800
        //Job id : 200    Task id : 650
        //Job id : 500    Task id : 300
        //Job id : 600    Task id : 350
        //Job id : 1000    Task id : 100
        //Job id : 500    Task id : 350
        //Job id : 600    Task id : 600
        //Choose any data structure of the input (array of structures or linked lists or queue).
        //Design Test cases for the same.
        public static bool PrintJobIdAndTaskId(int[] arr)
        {

            return true;
        }

        //Given a mess of 3 balls(colored red blue and white) write an algorithm + program with the most efficient way to sort them color wise. (Dutch National Flag Problem)
        public static bool SortBallInColourWise(int[] arr)
        {

            return true;
        }
        //Given a string print the string with alternate occurrences of any character dropped.
        public static bool PrintAlternateOccurencewithCharDropped(int[] arr)
        {
            return true;
        }

        //Smallest power of 2 which is greater than or equal to sum of array elements
        //Given an array of N numbers where values of the array represent memory sizes.The memory that is required by the system can only be represented in powers of 2. The task is to return the size of the memory required by the system.
        //Examples:
        //Input: a[] = {2, 1, 4, 5}
        //Output: 16
        //The sum of memory required is 12, 
        //hence the nearest power of 2 is 16. 

        //Input: a[] = {1, 2, 3, 2}
        //Output: 8
        public static bool printSmallestPowerof2GEToSumOfArrayElement(int[] arr)
        {
            return true;
        }

        public static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        public static void checkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        public static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }
    }
}
