namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");

            double sum = 0;
            int countOnes = 0;
            int countEven = 0;
            int countOdd = 0;

            while (true)

            {
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == -1)
                {
                    break;
                }

                if (userInput % 2 == 0)
                {
                    countEven++;
                }

                else
                {
                    countOdd++;
                }

                sum += userInput;
                countOnes++;
            }

            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + countOnes);
            Console.WriteLine("Average: " + (sum / countOnes));
            Console.WriteLine("Even: " + countEven);
            Console.WriteLine("Odd: " + countOdd);


        }
    }

}