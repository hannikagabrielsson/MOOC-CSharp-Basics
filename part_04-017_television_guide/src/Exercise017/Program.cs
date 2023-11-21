namespace Exercise017
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            List<TelevisionProgram> list = new List<TelevisionProgram>();
            // IMPLEMENT YOUR CODE IN HERE!

            while (true)
            {
                Console.Write("Name: ");
                string programName = Console.ReadLine();

                if (programName == "")
                {
                    break;
                }

                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                list.Add(new TelevisionProgram(programName, duration));
            }

            Console.WriteLine();
            Console.Write("Program's maximum duration? ");
            int maximumDuration = Convert.ToInt32(Console.ReadLine());

            foreach (TelevisionProgram item in list)
            {
                if (item.duration <= maximumDuration)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}