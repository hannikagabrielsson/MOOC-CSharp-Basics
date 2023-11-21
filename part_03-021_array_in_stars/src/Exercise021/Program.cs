namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
        }

        public static void PrintArrayInStars(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];

                for (int ii = 0; ii < number; ii++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}