namespace Exercise036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine(number * number);
                    continue;

                }

                if (number < 0)
                {
                    Console.WriteLine("That is negative");
                    continue;
                }

                if (number == 0)
                {
                    break;
                }
            }
        }
    }
}
