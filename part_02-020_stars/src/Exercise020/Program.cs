namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17, 3);
            PrintTriangle(4);
        }
        public static void PrintStars(int stars)
        {
            for (int i = 1; i <= stars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        public static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }

        public static void PrintRectangle(int width, int height)
        {
            int countOnes = 0;

            while (true)
            {
                for (int i = 1; i <= width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                countOnes++;

                if (countOnes == height)
                {
                    break;
                }
            }
        }

        public static void PrintTriangle(int size)
        {
            int stars = 0;
            while (true)
            {
                stars++;
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

                if (stars == size)
                {
                    break;
                }
            }
        }
    }
}