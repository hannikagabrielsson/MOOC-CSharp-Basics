namespace Exercise010
{
    using System;

    public class Gauge
    {
        public int value { get; set; }

        public Gauge()
        {
            this.value = 0;
        }

        public void Increase()
        {
            if (value < 5)
            {
                value = value + 1;
            }
        }

        public void Decrease()
        {
            if (value > 0)
            {
                value = value - 1;
            }

        }

        public bool Full()
        {
            if (value == 5)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}