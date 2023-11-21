namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Smallest(3, 53);
        }
        public static int Smallest(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }

            else
            {
                return number2;
            }
        }
    }
}
