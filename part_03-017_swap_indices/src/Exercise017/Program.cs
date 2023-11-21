namespace Exercise017
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }

            Console.WriteLine("Give two indices to swap:");

            int firstIndex = Convert.ToInt32(Console.ReadLine());

            int secondIndex = Convert.ToInt32(Console.ReadLine());

            int firstNumber = array[firstIndex];
            int secondNumber = array[secondIndex];

            array[firstIndex] = secondNumber;
            array[secondIndex] = firstNumber;



            // Implement here
            // asking for the two indices
            // and then swapping them

            // DO NOT CHANGE THE FOLLOWING CODE!
            Console.WriteLine("");
            index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }
    }
}
