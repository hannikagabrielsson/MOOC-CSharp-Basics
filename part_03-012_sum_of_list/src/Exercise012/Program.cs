namespace Exercise012
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
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int value = list[i];
                sum = sum + value;

            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}