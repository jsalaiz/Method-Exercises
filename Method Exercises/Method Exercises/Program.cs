using System;

namespace Method_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
        }
        static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{name} wouldn't it be crazy if a {color} {animal} played in {band}?");
        }
        static void Exercise2()
        {
            Console.WriteLine("Enter the number of digits you have");
            int numOfInts = Convert.ToInt32(Console.ReadLine());
            int[] listOfNums = new int[numOfInts];
            for (int i = 0; i < numOfInts; i++)
                {
                    Console.WriteLine("Type an integer");
                    listOfNums[i] = Convert.ToInt32(Console.ReadLine());    
                }
            int sumResult = 0;
            int multiplyResult = 0;
            sumResult = Sum(listOfNums);
            multiplyResult = Multiply(listOfNums);
            Console.WriteLine($"Your integers added together are: {sumResult}");
            Console.WriteLine($"Your integers multiplied together are: {multiplyResult}");

        }
        static int Sum(params int[] nums)
        {
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;
        }
        static int Multiply(params int[] nums)
        {
            int result = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                result *= nums[i];
            }
            return result;
        }

    }
}
