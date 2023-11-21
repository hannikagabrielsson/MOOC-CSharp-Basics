namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            string days = Console.ReadLine();
            int userInput = Convert.ToInt32(days);
            int calcWithoutBrackets = 60 * 60 * 24;
            Console.WriteLine(calcWithoutBrackets * userInput);
        }
    }
}
