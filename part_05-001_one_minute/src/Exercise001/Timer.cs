namespace Exercise001
{
    using System;

    public class Timer
    {
        // public int hundredthsOfASecond, second;
        public ClockHand second;
        public ClockHand hundredth;


        public Timer()
        {
            this.hundredth = new ClockHand(100);
            this.second = new ClockHand(60);
        }

        public void Advance()
        {
            this.hundredth.Advance();

            // this.hundredths = this.hundredths + 1;
            if (this.hundredth.value == 0)
            {
                this.second.Advance();
            }

        }

        public override string ToString()
        {
            return this.second + ":" + this.hundredth;
        }
    }
}