namespace Exercise010
{
    using System;
    public class Apartment
    {

        private int rooms;
        private int squares;
        private int pricePerSquare;

        public Apartment(int rooms, int squares, int pricePerSquare)
        {
            this.rooms = rooms;
            this.squares = squares;
            this.pricePerSquare = pricePerSquare;
        }

        public bool LargerThan(Apartment compared)
        {
            if (this.squares > compared.squares)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Price()
        {
            int price = this.squares * this.pricePerSquare;
            return price;
        }

        public int PriceDifference(Apartment compared)
        {
            // int difference = this.squares * this.pricePerSquare - compared;
            int difference = Price() - compared.Price();

            difference = Math.Abs(difference);

            // Math.Abs returns the absolute value

            return difference;
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if (Price() > compared.Price())
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