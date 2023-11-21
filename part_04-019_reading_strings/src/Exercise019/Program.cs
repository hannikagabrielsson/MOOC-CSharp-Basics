namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
