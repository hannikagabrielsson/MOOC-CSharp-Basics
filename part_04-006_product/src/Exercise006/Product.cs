namespace Exercise006
{
    using System;

    public class Product
    {
        public double price;
        public int quantity;
        public string name;

        public Product(string name, double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            this.name = name;
        }

        public void PrintProduct()
        {
            Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantity + " pcs");
        }
    }
}