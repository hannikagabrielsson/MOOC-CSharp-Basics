namespace Exercise001
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Account hannika = new Account("Hannika", 100.00);

            hannika.Deposit(20.00);
            Console.WriteLine(hannika.balance);
        }
    }
}
