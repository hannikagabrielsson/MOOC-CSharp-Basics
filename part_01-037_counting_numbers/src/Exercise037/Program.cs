namespace Exercise037
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

                if (number == 0)
                {
                    break;
                }
                input = input + 1;
            }
            Console.WriteLine("Total amount of numbers: " + input);
        }
    }
}
