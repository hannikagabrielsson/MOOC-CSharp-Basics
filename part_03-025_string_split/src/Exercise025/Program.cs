namespace Exercise025
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
                string empty = "";

                if (text == empty)
                {
                    break;
                }

                for (int i = 0; i < pieces.Length; i++)
                {
                    Console.WriteLine(pieces[i]);
                }
            }
        }
    }
}
