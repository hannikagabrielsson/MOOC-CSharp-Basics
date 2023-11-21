namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            string name = " ";

            while (true)
            {
                string text = Console.ReadLine();
                string[] pieces = text.Split(",");
                string stop = "";

                if (text == stop)
                {
                    break;
                }

                int age = Convert.ToInt32(pieces[1]);

                if (age > oldest)
                {
                    oldest = age;
                    name = pieces[0];
                }
            }

            Console.WriteLine("Name of the oldest: " + name);
        }
    }
}