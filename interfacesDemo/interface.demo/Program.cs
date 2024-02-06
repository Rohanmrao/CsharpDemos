using myInterfaceNS;
using System;

namespace interfaceDemo
{

    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World");

            int firstNum = 10;
            int secondNum = 10;
            MyInterface myInterface = new MyInterface();
            int sum = myInterface.AddTwoNums(a:firstNum, b:secondNum);
            Console.WriteLine($"The second print (return value) : {sum}");

            int diff = myInterface.DiffTwoNums(a:firstNum, b:secondNum);
            Console.WriteLine(diff);
        }
    }

    public class MyInterface : IMyInterface
    {
        public int AddTwoNums(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($" The sum is : {sum}");

            return sum;
        }

        public int DiffTwoNums(int a, int b)
        {
            return a-b;
        }
    }
    
    
}



