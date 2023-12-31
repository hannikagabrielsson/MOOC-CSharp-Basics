namespace Exercise002
{
    using System;

    public class Cube
    {
        public int edge;

        public Cube(int edgeLength)
        {
            this.edge = edgeLength;
        }

        public int Volume()
        {
            return this.edge * this.edge * this.edge;

        }

        public override string ToString()
        {
            return "The length of the edge is " + this.edge + " and the volume " + Volume();
        }
    }
}