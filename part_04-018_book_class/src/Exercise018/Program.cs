namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // implement here the program that allows the user to enter 
            // book information and to examine them


            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }
                Console.Write("Pages: ");
                // int numberOfPages = Convert.ToInt32(Console.ReadLine());
                int numberOfPages = Convert.ToInt32(Console.ReadLine());

                Console.Write("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(name, numberOfPages, year));
            }

            Console.WriteLine();

            Console.Write("What information will be printed? ");
            string answer = Console.ReadLine();
            string everything = "everything";
            string title = "title";

            if (answer == everything)
            {
                foreach (Book item in books)
                {
                    Console.WriteLine(item);
                }
            }

            else if (answer == title)
            {
                foreach (Book item in books)
                {
                    Console.WriteLine(item.name);
                }
            }

            else
            {
                // Doesn't print anything.
            }
        }
    }
}