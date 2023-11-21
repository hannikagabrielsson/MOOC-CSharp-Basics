namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string userInput = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            string number = Console.ReadLine();
            int intValue = Convert.ToInt32(number);

            Console.WriteLine("Give a double:");
            string numberDecimal = Console.ReadLine();
            double doubleValue = Convert.ToDouble(numberDecimal);

            Console.WriteLine("Give a boolean:");
            string True = Console.ReadLine();
            bool booleanValue = Convert.ToBoolean(True);

            Console.WriteLine("Your string: " + userInput + "\n" +
            "Your integer: " + intValue + "\n" +
            "Your double: " + doubleValue + "\n" +
            "Your boolean: " + booleanValue);



        }
    }
}
