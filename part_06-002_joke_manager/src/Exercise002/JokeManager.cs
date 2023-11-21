namespace Exercise002
{
    using System;
    using System.Collections.Generic;

    public class JokeManager
    {
        private List<string> jokes;
        public JokeManager()
        {
            this.jokes = new List<string>();
        }

        public void AddJoke(string joke)
        {
            this.jokes.Add(joke);
        }

        public string DrawJoke()
        {
            if (this.jokes.Count == 0)
            {
                string shortSupply = "Jokes are in short supply";
                return shortSupply;
            }

            else
            {
                Random random = new Random();
                int randomIndex = random.Next(this.jokes.Count);
                string randomJoke = this.jokes[randomIndex];

                return randomJoke;
            }

        }

        public void PrintJokes()
        {
            foreach (string joke in jokes)
            {
                System.Console.WriteLine(joke);
            }
        }
    }
}