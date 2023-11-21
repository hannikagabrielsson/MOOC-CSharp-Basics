namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(String[] args)
        {
            ChristmasTree(7);
        }

        public static void PrintSpaces(int number)
        {
            for (int i = 1; i <= number; i++)
                Console.Write(" ");
        }

        public static void PrintStars(int stars)
        {
            for (int i = 1; i <= stars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintRightTriangle(int size)
        {
            int stars = 0;
            int number = size;
            for (int i = 1; i <= size; i++)
            {
                number--;
                PrintSpaces(number);
                stars++;
                PrintStars(stars);
            }
        }
        public static void PrintTriangle(int size)
        {
            int stars = 0;
            int number = size;
            for (int i = 1; i <= size; i++)
            {
                number--;
                PrintSpaces(number);
                stars++;
                PrintStars(stars);
                stars++;
            }
            int foot = 2;
            number = size - foot;
            stars = 3;
            for (int i = 1; i <= foot; i++)
            {
                PrintSpaces(number);
                PrintStars(stars);
            }
        }

        public static void ChristmasTree(int height)
        {
            PrintTriangle(height);
        }
    }
}