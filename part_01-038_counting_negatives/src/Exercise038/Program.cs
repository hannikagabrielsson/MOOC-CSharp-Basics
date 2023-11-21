namespace Exercise038
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    input = input + 1;
                }

                if (number == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + input);
        }
    }
}
