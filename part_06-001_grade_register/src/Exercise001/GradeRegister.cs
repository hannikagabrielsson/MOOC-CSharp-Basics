namespace Exercise001
{
    using System.Collections.Generic;
    using System;
    public class GradeRegister
    {
        private List<int> grades;
        private List<int> points;

        public GradeRegister()
        {
            this.grades = new List<int>();
            this.points = new List<int>();
        }

        public void AddGradeBasedOnPoints(int points)
        {
            this.points.Add(points);
            this.grades.Add(PointsToGrades(points));
        }

        public int NumberOfGrades(int grade)
        {
            int count = 0;
            foreach (int received in this.grades)
            {
                if (received == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PointsToGrades(int points)
        {
            int grade = 0;
            if (points < 50)
            {
                grade = 0;
            }
            else if (points < 60)
            {
                grade = 1;
            }
            else if (points < 70)
            {
                grade = 2;
            }
            else if (points < 80)
            {
                grade = 3;
            }
            else if (points < 90)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            return grade;
        }

        public double AverageOfGrades()
        {
            double allGrades = 0;

            if (this.grades.Count == 0)
            {
                return -1;
            }

            foreach (double grade in this.grades)
            {
                allGrades = allGrades + grade;
            }
            double average = allGrades / this.grades.Count;

            return Math.Round(average, 2);
        }

        public double AverageOfPoints()
        {
            if (this.points.Count == 0)
            {
                return -1;
            }

            double allPoints = 0;

            foreach (double point in this.points)
            {
                allPoints += point;
            }

            double average = allPoints / this.points.Count;

            return Math.Round(average, 2);

        }
    }
}