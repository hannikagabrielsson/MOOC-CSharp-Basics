namespace Exercise003
{
    using System;
    public class Fitbyte
    {
        public int age, heartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.heartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * this.age);

            return (maxHeartRate - this.heartRate) * (percentageOfMaximum) + this.heartRate;
        }
    }
}