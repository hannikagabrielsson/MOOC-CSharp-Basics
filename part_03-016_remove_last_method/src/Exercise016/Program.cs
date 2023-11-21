namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Matti");
            names.Add("Irma");
            names.Add("Tuomas");
            names.Add("Katja");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            RemoveLast(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void RemoveLast(List<string> strings)
        {
            strings.RemoveAt(strings.Count - 1);
        }
    }
}

