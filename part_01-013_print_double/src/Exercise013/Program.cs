namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string userInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(userInput);
            Console.WriteLine("You gave " + doubleValue);
        }
    }
}
