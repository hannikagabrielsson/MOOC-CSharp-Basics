namespace Exercise023
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

            int sum = first + second;
            int difference = first - second;
            int product = first * second;
            double quotient = Convert.ToDouble(first) / Convert.ToDouble(second);

            Console.WriteLine(first + " + " + second + " = " + sum + "\n" +
            first + " - " + second + " = " + difference + "\n" +
            first + " * " + second + " = " + product + "\n" +
            first + " / " + second + " = " + quotient);
        }
    }
}
