using System;

namespace csharp_examples;

    /*

        TODO: 
        1. Variables and data types 
        2. OOOPS structures  
        3. Namespaces
        4. Importing functions into cs files from other cs files 
        5. Interfaces and scoping 

        */ 

    public class Program_2 
    {
        public void Main_2(string[] args)
        {
            Console.WriteLine($"Hello from Program_2 {args[0]}");

            int num = 0;
            float floatNum = 10f;
            string stExample = "This is a string";
            bool isTrue = true;
            char chExample = 'A';
            var someVar = "Hi";

            int[] intArray = {1,2,3};

            Console.WriteLine(num);
            Console.WriteLine(floatNum);
            Console.WriteLine(stExample);
            Console.WriteLine(isTrue);
            Console.WriteLine(chExample);
            Console.WriteLine(someVar.GetType());
            Console.WriteLine(intArray[0]);

        }
    }

    class forLoops
    {
        public void forLooper(string[] args)
        {
            int[] myArr = {1,2,3,4,5};
            for (int i = 0; i < 5; i = i + 1)
            {
                Console.WriteLine($"{args[0]} {myArr[i]}");
            }
        }
    }

    class Converter
    {
        public static void tryCatch(string[] args)
        {
            var myNum = "123";
            
            try 
            {
                int myNum_int = Convert.ToByte(myNum);
                Console.WriteLine(myNum_int);
                Console.WriteLine(myNum_int.GetType());
            }
            catch (Exception)
            {
                Console.WriteLine("\nNo can do");
    
            }


            
        }
    }

    class Program
    {
        static void Main(string[] args) // Main is always the entry point
        {
            Console.WriteLine("What's your name ?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"My name is {name}");

            Program_2 Obj = new Program_2();
            Obj.Main_2(new string[] {"Bingo"});

            forLoops looper = new forLoops();
            looper.forLooper(new string[] {"Hi"});

            Converter.tryCatch(new string[] {""});
        }
    }




