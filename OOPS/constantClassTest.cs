using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class constantClassTest
    {
        public const int var1 = 10;
        public static int var2 = 20;
        public readonly int var3 = 30;
        public int var4;
        public constantClassTest()
        {
            //var1 = 100;
            var2 = 200;
            var3 = 300;
            var4 = 400;
        }
        static constantClassTest()
        {
            var2 = 200;
        }
        public void printValue()
        {
            Console.WriteLine("Var1- " + var1);
            Console.WriteLine("Var2- " + var2);
            Console.WriteLine("Var3- " + var3);
            Console.WriteLine("Var4- " + var4);
        }
    }
}
