using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class ParentClass
    {
        private string PrivateVaribale;
        public string publicVaribale;
        protected string protectedvaribale;
        internal string internalVaribale;
        protected internal string protectedinternalvaribale;
        private void privateMethod()
        {
            Console.WriteLine("Parent Public Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Parent public Method");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("Parent protected Method");
        }
        internal void internalMethod()
        {
            Console.WriteLine("Parent internal Method");
        }
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("Parent protected internal Method");
        }
    }

    class ChildClass : ParentClass
    {
        private string PrivateVaribale;
        public string publicVaribale;
        protected string protectedvaribale;
        internal string internalVaribale;
        protected internal string protectedinternalvaribale;
        private void privateMethod()
        {
            Console.WriteLine("Child Public Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Child public Method");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("Child protected Method");
        }
        internal void internalMethod()
        {
            Console.WriteLine("Child internal Method");
        }
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("Child protected internal Method");
        }
    }
}
