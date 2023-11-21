namespace Exercise010
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }

            Console.WriteLine("Search for?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (list.Contains(userInput))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int number = list[i];
                    if (number == userInput)
                    {
                        Console.WriteLine(userInput + " is at index " + i);
                    }
                }
            }
        }
    }
}
