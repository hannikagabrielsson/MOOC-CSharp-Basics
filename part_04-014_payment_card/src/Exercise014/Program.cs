namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(100);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);

            card.AddMoney(49.99);
            Console.WriteLine(card);

            card.AddMoney(10000.00);
            Console.WriteLine(card);

            card.AddMoney(-10);
            Console.WriteLine(card);
        }
    }
}