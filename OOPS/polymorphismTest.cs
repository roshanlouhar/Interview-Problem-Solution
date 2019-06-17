using System;

namespace OOPS
{
    class polymorphismclass
    {
        private void privateMethod1()
        {
            Console.WriteLine("polymorphismclass privateMethod1 no parameter");
        }
        private void privateMethod1(string test)
        {
            Console.WriteLine("polymorphismclass privateMethod1 with parameter" + test);
        }

        public virtual void publicMethod2()
        {
            privateMethod1();
            Console.WriteLine("polymorphismclass publicMethod2 no parameter");
        }
        public virtual void publicMethod2(string test)
        {
            privateMethod1(test);
            Console.WriteLine("polymorphismclass publicMethod2 with parameter" + test);
        }

        public virtual void publicMethod3()
        {
            Console.WriteLine("polymorphismclass publicMethod3 no parameter");
        }
    }

    class DerivedPolymorphismClass : polymorphismclass
    {
        private void privateMethod1()
        {
            Console.WriteLine("DerivedPolymorphismClass privateMethod1 no parameter");
        }
        private void privateMethod1(string test)
        {
            Console.WriteLine("DerivedPolymorphismClass privateMethod1 with parameter" + test);
        }
        public override void publicMethod2()
        {
            privateMethod1();
            Console.WriteLine("DerivedPolymorphismClass publicMethod2 no parameter");
        }
        public override void publicMethod2(string test)
        {
            privateMethod1(test);
            Console.WriteLine("DerivedPolymorphismClass publicMethod2 with parameter" + test);
        }
        public new void publicMethod3()
        {
            Console.WriteLine("DerivedPolymorphismClass publicMethod3 no parameter");
        }

    }
}
