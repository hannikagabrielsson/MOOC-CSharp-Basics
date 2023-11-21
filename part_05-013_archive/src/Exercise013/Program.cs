namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.

            while (true)
            {
                System.Console.WriteLine("Identifier? (empty will stop):");
                string identifier = Console.ReadLine();

                if (identifier == "")
                {
                    break;
                }

                System.Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                Item item = new Item(identifier, name);

                if (!items.Contains(item))
                {
                    items.Add(new Item(identifier, name));
                }
            }

            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}