namespace Exercise034
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string question = ("Do you want to continue?");
            string answer = "";

            while (true)
            {
                Console.WriteLine(question);
                answer = Console.ReadLine();

                if (answer == "no")
                {
                    break;
                }
            }
        }
    }
}

