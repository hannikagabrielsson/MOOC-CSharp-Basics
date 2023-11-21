namespace Exercise022
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

            Console.WriteLine("Give the third number!");
            string thirdNumber = Console.ReadLine();
            int third = Convert.ToInt32(thirdNumber);

            double average = Convert.ToDouble(first + second + third) / 3.0;

            Console.WriteLine("The average is " + average);



        }
    }
}
