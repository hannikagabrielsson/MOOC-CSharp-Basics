namespace Exercise028
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

                int length = pieces.Length - 1;
                Console.WriteLine(pieces[length]);
            }
        }
    }
}