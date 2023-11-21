namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string firstNumber = Console.ReadLine();
            int first = Convert.ToInt32(firstNumber);

            Console.WriteLine("Give the second number!");
            string secondNumber = Console.ReadLine();
            int second = Convert.ToInt32(secondNumber);

            double average = Convert.ToDouble(first + second) / 2.0;


            Console.WriteLine("The average is " + average);
        }
    }
}
