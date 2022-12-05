using System;

namespace TestClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClassObj = new TestClass();
            testClassObj.n = "qazweqe";
            testClassObj.x = 10;
            testClassObj.y = 8.5;

            TestClass testClassObj2 = new TestClass();
            testClassObj2.n = "New N";
            testClassObj2.x = 100;
            testClassObj2.y = 5.5;

            int t = 8;
            t = 9;
            t = 10;
            TestStaticClass.n = "2 new";
            TestStaticClass.n = "2 new,2 new,2 new,2 new";

            int first = (int)NewEnumClass.Monday;
            Console.WriteLine(first);
            string second = NewEnumClass.Monday.ToString();
            Console.WriteLine(second);

        }
    }
}

