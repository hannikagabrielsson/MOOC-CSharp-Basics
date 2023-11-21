namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                items.Add(new Item(name));

                if (name == "")
                {
                    break;
                }
            }

            Console.WriteLine("");
            foreach (Item name in items)
            {
                Console.WriteLine(name);

            }

        }
    }
}