namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                string stop = "";
                string[] pieces = text.Split(" ");

                if (text == stop)
                {
                    break;
                }
                foreach (string piece in pieces)
                {
                    if (piece.Contains("av"))
                    {
                        Console.WriteLine(piece);
                    }
                }
            }
        }
    }
}