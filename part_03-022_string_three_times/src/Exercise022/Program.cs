namespace Exercise022
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give a word: ");
            string text = Console.ReadLine();
            Console.WriteLine(text + text + text);
        }
    }
}
