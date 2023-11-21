namespace Exercise018
{
    using System;
    public class Book
    {
        public string name { get; set; }
        public int numberOfPages { get; set; }
        public int year { get; set; }


        public Book(string name, int numberOfPages, int year)
        {
            this.name = name;
            this.numberOfPages = numberOfPages;
            this.year = year;
        }

        public override string ToString()
        {
            return this.name + ", " + this.numberOfPages + " pages, " + this.year;
        }
    }


}