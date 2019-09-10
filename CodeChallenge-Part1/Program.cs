using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_Part1
{

    static class extended
    {
        public static string extendedMethod(this string str)
        {
            return str.ToUpper();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //int[] singleDimArray = { 1, 2, 3, 4 };
            //int[,] multiDimArray = { { 1, 2 }, { 3, 4 } };
            //int[][] jaggedArray = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            //Console.WriteLine(singleDimArray.Length);
            //Console.WriteLine(multiDimArray.Length);
            //Console.WriteLine(jaggedArray.Length);

            //float num = 56, div = 0;
            //try
            //{
            //    var test = (num / div);
            //    Console.WriteLine(test);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Division By Zero");
            //}

            int n1 = 8, n2 = 16;
            var r1 = n1 & n1;
            var r2 = n1 | n1;
            var r5 = n1 ^ n1;

            var r3 = n1 << 1;
            var r4 = n1 >> 1;

            


            Console.ReadLine();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
