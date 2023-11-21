namespace Exercise020
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

            int product = first * second;

            Console.WriteLine(first + " * " + second + " = " + product);
        }
    }
}
