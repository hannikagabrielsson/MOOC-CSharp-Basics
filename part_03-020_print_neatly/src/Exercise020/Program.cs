namespace Exercise020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // You can test your method here
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {

            int length = array.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                int number = array[i];
                if (i < length)
                {
                    Console.Write(number + ", ");
                }

                if (i == length)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
