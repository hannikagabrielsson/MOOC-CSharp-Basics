namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your year of birth:");
            string yearOfBirth = Console.ReadLine();
            int userInput = Convert.ToInt32(yearOfBirth);

            if (userInput < 1900)
            {
                Console.WriteLine("You're old");
            }
        }
    }
}
