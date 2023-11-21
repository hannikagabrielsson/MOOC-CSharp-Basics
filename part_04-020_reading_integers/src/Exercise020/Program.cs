namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                int number = Convert.ToInt32(input);
                Console.WriteLine(number * number * number);
            }
        }
    }
}