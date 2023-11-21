namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("How many times?");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int start = 0; start < numberOfTimes; start++)
            {
                PrintPhrase();
            }

        }
        public static void PrintPhrase()
        {
            System.Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}