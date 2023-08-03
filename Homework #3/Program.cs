using Homework__3.Part_1;

namespace Homework__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.ArrayTest(25);
            test.ArrayTest(10, 83);
            test.ArrayTest(10, true);
            test.ArrayTest(10, false);
        }
    }
}