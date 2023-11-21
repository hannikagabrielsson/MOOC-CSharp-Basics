namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            string userInput = Console.ReadLine();
            bool boolValue = Convert.ToBoolean(userInput);
            Console.WriteLine(boolValue);

        }
    }
}
