namespace Exercise001
{
    using System;
    public class UserInterface
    {
        private GradeRegister register;

        public UserInterface(GradeRegister register)
        {
            this.register = register;
        }

        public void Start()
        {
            ReadPoints();
            Console.WriteLine("");
            PrintGradeDistribution();
        }

        public void ReadPoints()
        {
            while (true)
            {
                Console.WriteLine("Points:");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                int score = Convert.ToInt32(input);

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Impossible number.");
                    continue;
                }
                register.AddGradeBasedOnPoints(score);
            }
        }

        public void PrintGradeDistribution()
        {
            int grade = 5;
            while (grade >= 0)
            {
                int stars = register.NumberOfGrades(grade);
                Console.Write(grade + ": ");
                PrintStars(stars);
                Console.WriteLine();

                grade = grade - 1;
            }

            double pointsAverage = register.AverageOfPoints();
            double gradesAverage = register.AverageOfGrades();

            Console.WriteLine("The average of points: " + pointsAverage);
            Console.WriteLine("The average of grades: " + gradesAverage);
            // Print average of points & grades

        }
        public static void PrintStars(int stars)
        {
            while (stars > 0)
            {
                Console.Write("*");
                stars--;
            }
        }
    }
}