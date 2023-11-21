namespace Exercise023
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string word = "true";
            string text = Console.ReadLine();

            if (text == word)
            {
                Console.WriteLine("You got it right!");
            }

            else
            {
                Console.WriteLine("Try again!");
            }

        }
    }
}
