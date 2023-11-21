namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string firstNumber = Console.ReadLine();
            int a = Convert.ToInt32(firstNumber);

            Console.WriteLine("Give the second number!");
            string secondNumber = Console.ReadLine();
            int b = Convert.ToInt32(secondNumber);

            if (a > b)
            {
                Console.WriteLine("The larger number is " + a + "!");
            }

            else if (b > a)
            {
                Console.WriteLine("The larger number is " + b + "!");
            }

            else
            {
                Console.WriteLine("They are equal!");
            }
        }
    }
}
