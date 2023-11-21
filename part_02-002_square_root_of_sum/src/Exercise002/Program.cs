namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            double squareRoot = Math.Sqrt(firstNumber + secondNumber);
            Console.WriteLine(squareRoot);
        }
    }
}
