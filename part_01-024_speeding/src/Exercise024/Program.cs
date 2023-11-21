namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            string speed = Console.ReadLine();
            int userInput = Convert.ToInt32(speed);

            if (userInput > 120)
            {
                Console.WriteLine("Speeding!");
            }
        }
    }
}
