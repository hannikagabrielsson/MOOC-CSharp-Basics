namespace Exercise006
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 100; i >= input; input++)
            {
                Console.WriteLine(input);
            }
        }
    }
}