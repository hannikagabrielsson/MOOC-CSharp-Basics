namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 3000;
            int longest = 0;
            string longestName = " ";

            while (true)
            {
                string text = Console.ReadLine();
                string[] pieces = text.Split(",");
                string stop = "";

                if (text == stop)
                {
                    break;
                }

                string name = pieces[0];
                int length = name.Length;

                if (length > longest)
                {
                    longest = length;
                    longestName = pieces[0];
                }

                int year = Convert.ToInt32(pieces[1]);

                if (year < oldest)
                {
                    oldest = year;
                }
            }

            Console.WriteLine("Longest name: " + longestName);
            oldest = 2023 - oldest;
            Console.WriteLine("Highest age: " + oldest);
        }
    }
}