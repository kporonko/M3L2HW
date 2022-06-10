using System;
using static Delegates.Class1;

namespace Delegates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.Delegate1 = Show;
            Class2 class2 = new Class2();

            var powRes = class2.Calc(class2.PowDelegate, 10, 7);
            class1.Delegate1(powRes(5));
            Console.ReadLine();
        }

        public static void Show(bool val)
        {
            Console.WriteLine(val);
        }
    }
}
