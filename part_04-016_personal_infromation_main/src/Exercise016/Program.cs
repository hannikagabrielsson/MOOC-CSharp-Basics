namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PersonalInformation> list = new List<PersonalInformation>();
            // IMPLEMENT YOUR CODE IN HERE!

            while (true)
            {
                Console.WriteLine("First name:");
                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }

                Console.WriteLine("Last name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Identification number:");
                string number = Console.ReadLine();

                list.Add(new PersonalInformation(firstName, lastName, number));
            }

            Console.WriteLine();

            foreach (PersonalInformation item in list)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
                // Print only first and last name!

            }

        }
    }
}