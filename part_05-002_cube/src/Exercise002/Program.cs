namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // You can test different cubes here.
            Cube smallCube = new Cube(5);
            Cube bigCube = new Cube(15);

            Console.WriteLine(smallCube);
            Console.WriteLine(bigCube);

        }
    }
}