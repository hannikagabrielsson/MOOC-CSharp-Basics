namespace Exercise005
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = input;

            for (input = 0; input <= end; input++)
            {
                Console.WriteLine(input);
            }
        }
    }
}
