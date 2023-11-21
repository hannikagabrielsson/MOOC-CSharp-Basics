namespace Exercise035
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a number:");
                string userInput = Console.ReadLine();
                int number = Convert.ToInt32(userInput);
                if (number == 42)
                {
                    break;
                }
            }
        }
    }
}
