namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // string[] usernames = new string[2];
            // string[] passwords = new string[2];

            // usernames[0] = "alex";
            // passwords[0] = "sunshine";
            // usernames[1] = "emma";
            // passwords[1] = "haskell";
            string username1 = "alex";
            string password1 = "sunshine";
            string username2 = "emma";
            string password2 = "haskell";

            Console.WriteLine("Enter username:");
            string userInputUsername = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string userInputPassword = Console.ReadLine();

            if (userInputUsername == username1 && userInputPassword == password1)
            {
                Console.WriteLine("You have successfully logged in!");
            }

            else if (userInputUsername == username2 && userInputPassword == password2)
            {
                Console.WriteLine("You have successfully logged in!");

            }

            else
            {
                Console.WriteLine("Incorrect username or password!");
            }


            // for (int i = 0; i < usernames.Length; i++)
            // {
            //     if (usernames[i] == userInputUsername && passwords[i] == userInputPassword)
            //     {
            //         // if (passwords[i] == userInputPassword)
            //         // {
            //         Console.WriteLine("You have successfully logged in!");
            //     }

            //     // if (usernames[i] != userInputUsername && passwords[i] != userInputPassword)
            //     // {
            //     //     Console.WriteLine("Incorrect username or password!");
            //     // }
            // }
        }
    }
}