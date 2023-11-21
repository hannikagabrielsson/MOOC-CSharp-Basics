namespace Exercise040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                number = number + 1;
                sum = sum + input;
            }

            Console.WriteLine("Total sum of numbers: " + sum +
            "\nTotal amount of numbers: " + number);
        }
    }
}
