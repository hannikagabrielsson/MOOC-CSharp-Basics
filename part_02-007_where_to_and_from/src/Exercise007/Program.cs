namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Where to?");
            System.Console.WriteLine("Where from?");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            for (int i = input2; i <= input1; i++)
            {
                System.Console.WriteLine(i);
            }

        }
    }
}
