namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int answer = Greatest(5, 7, 3);
            Console.WriteLine("Greatest: " + answer);
        }

        public static int Greatest(int first, int second, int third)
        {
            if ((first >= second) && (first >= third))
            {
                return first;
            }

            else if ((second >= first) && (second >= third))
            {
                return second;
            }

            else
            {
                return third;
            }
        }
    }
}
