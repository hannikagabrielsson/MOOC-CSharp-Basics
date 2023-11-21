namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            string number = Console.ReadLine();
            int userInput = Convert.ToInt32(number);

            if (userInput == 1984)
            {
                Console.WriteLine("Orwell");
            }
        }
    }
}
