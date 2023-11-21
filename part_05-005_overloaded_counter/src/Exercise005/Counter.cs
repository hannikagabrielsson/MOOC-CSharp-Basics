namespace Exercise005
{
    using System;

    public class Counter
    {
        public int value { get; set; }

        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public Counter() : this(0)
        {
            // this.value = 0;
        }

        public void Increase()
        {
            this.Increase(1);
            // this.value++;
        }

        public void Decrease()
        {
            this.Decrease(1);
            // this.value--;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy >= 0)
            {
                this.value = this.value + increaseBy;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy >= 0)
            {
                this.value = this.value - decreaseBy;
            }
        }

        // public override string ToString()
        // {
        //     return "The counter's value is: " + this.Value;
        // }
    }
}