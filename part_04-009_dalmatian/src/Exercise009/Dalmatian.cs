namespace Exercise009
{
    using System;

    public class Dalmatian
    {
        public string name { get; set; }
        public int spots;

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }
    }
}