namespace Exercise022
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");

            string[] text = File.ReadAllLines(Console.ReadLine());
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}