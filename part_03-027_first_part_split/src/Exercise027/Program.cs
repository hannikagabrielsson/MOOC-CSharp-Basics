namespace Exercise027
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                string[] pieces = text.Split(" ");
                string stop = "";

                if (text == stop)
                {
                    break;
                }

                Console.WriteLine(pieces[0]);
            }
        }
    }
}