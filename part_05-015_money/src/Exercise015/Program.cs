namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Money money = new Money(100, 59);
            Money moreMoney = new Money(500, 50);

            Money combined = moreMoney.Plus(moreMoney);

            Console.WriteLine(money + " money");
            Console.WriteLine(moreMoney + " more money");
            Console.WriteLine(combined + " combined");

            combined = combined.Plus(moreMoney);

            Money lessMoney = new Money(100, 69);

            Money newMoney = money.Minus(lessMoney);
            System.Console.WriteLine(money + " money");
            Console.WriteLine(lessMoney + " less money");

            Console.WriteLine(newMoney + " new money");

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            lessMoney = lessMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);
            Console.WriteLine(moreMoney);

            Console.WriteLine(lessMoney.LessThan(moreMoney));
            Console.WriteLine(lessMoney.LessThan(money));

            lessMoney = lessMoney.Minus(moreMoney);
            Console.WriteLine(lessMoney);
        }
    }
}