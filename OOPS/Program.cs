using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CheckInheritance();
            //CheckPolymorphism();
            //CheckKeywordVariable();
            //checkRefOutKeyword();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            Console.ReadKey();
        }

        static void checkRefOutKeyword()
        {
            int refVar = 10, outVar = 0, IntVar = 20;
            CheckRefOutLogic(IntVar, ref refVar, out outVar);

            Console.WriteLine("outVar- " + outVar);
            Console.WriteLine("refVar- " + refVar);
            Console.WriteLine("IntVar- " + IntVar);
        }

        static void CheckRefOutLogic(int IntVar, ref int refVar, out int outVar)
        {
            outVar = 300;
            refVar = refVar + 100;
            IntVar = 500;
            Console.WriteLine("Inside function outVar- " + outVar);
            Console.WriteLine("Inside function refVar- " + refVar);
            Console.WriteLine("Inside function IntVar- " + IntVar);
        }

        static void CheckInheritance()
        {
            #region Parent Class direct access without cast.
            ParentClass pobj = new ParentClass();
            //pobj.PrivateVaribale = "PrivateVaribale";
            //pobj.privateMethod();

            //pobj.protectedvaribale = "protectedvaribale";
            //pobj.protectedMethod();

            pobj.internalVaribale = "internalMethod";
            pobj.internalMethod();

            pobj.protectedinternalvaribale = "protectedinternalvaribale";
            pobj.protectedInternalMethod();

            pobj.publicVaribale = "publicVaribale";
            pobj.PublicMethod();
            #endregion

            #region Child Class direct access without cast.
            ChildClass cobj = new ChildClass();
            //cobj.PrivateVaribale = "PrivateVaribale";
            //cobj.privateMethod();

            //cobj.protectedvaribale = "protectedvaribale";
            //cobj.protectedMethod();

            cobj.internalVaribale = "internalMethod";
            cobj.internalMethod();

            cobj.protectedinternalvaribale = "protectedinternalvaribale";
            cobj.protectedInternalMethod();

            cobj.publicVaribale = "publicVaribale";
            cobj.PublicMethod();
            #endregion

            #region Parent Class object from child class.
            ParentClass pcobj = new ChildClass();
            //pcobj.PrivateVaribale = "PrivateVaribale";
            //pcobj.privateMethod();

            //pcobj.protectedvaribale = "protectedvaribale";
            //pcobj.protectedMethod();

            pcobj.internalVaribale = "internalMethod";
            pcobj.internalMethod();

            pcobj.protectedinternalvaribale = "protectedinternalvaribale";
            pcobj.protectedInternalMethod();

            pcobj.publicVaribale = "publicVaribale";
            pcobj.PublicMethod();
            #endregion

            #region Child Class object from Parent class.Not possible to create this Object
            //ChildClass cpobj = new ParentClass(); 
            ////cpobj.PrivateVaribale = "PrivateVaribale";
            ////cpobj.privateMethod();

            ////cpobj.protectedvaribale = "protectedvaribale";
            ////cpobj.protectedMethod();

            //cpobj.internalVaribale = "internalMethod";
            //cpobj.internalMethod();

            //cpobj.protectedinternalvaribale = "protectedinternalvaribale";
            //cpobj.protectedInternalMethod();

            //cpobj.publicVaribale = "publicVaribale";
            //cpobj.PublicMethod();
            #endregion
        }

        static void CheckPolymorphism()
        {
            polymorphismclass obj = new polymorphismclass();
            //Overloading of Methods
            //obj.publicMethod2();
            //obj.publicMethod2(" - Test by Roshan");

            //Method Overriding
            DerivedPolymorphismClass dobj = new DerivedPolymorphismClass();
            //dobj.publicMethod2();

            //Method Hiding Test
            polymorphismclass pdobj = new DerivedPolymorphismClass();
            obj.publicMethod3();
            dobj.publicMethod3();
            pdobj.publicMethod3();

        }

        static void CheckKeywordVariable()
        {
            constantClassTest obj = new constantClassTest();
            obj.printValue();
            //obj.
        }
    }
}
