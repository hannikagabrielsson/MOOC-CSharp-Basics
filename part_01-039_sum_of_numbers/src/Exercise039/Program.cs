namespace Exercise039
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                sum = sum + number;
            }
            Console.WriteLine("Total sum of numbers: " + sum);
        }
    }
}

