﻿namespace Exercise005
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
            }

            int totalNumberOfEntries = list.Count;
            totalNumberOfEntries = totalNumberOfEntries - 1;

            Console.WriteLine(list[totalNumberOfEntries]);
        }
    }
}
