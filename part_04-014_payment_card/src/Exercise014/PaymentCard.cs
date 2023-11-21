
namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }


        public override string ToString()
        {
            return "The card has a balance of " + this.balance + " euros";
        }

        public void EatLunch()
        {
            double lunch = 10.60;

            if (this.balance >= lunch)
            {
                this.balance = Convert.ToDouble(this.balance) - lunch;
            }
            else
            {
                this.balance = this.balance - 0;
            }
        }

        public void DrinkCoffee()
        {
            double coffee = 2.00;

            if (this.balance >= coffee)
            {
                this.balance = Convert.ToDouble(this.balance) - coffee;
            }
            else
            {
                this.balance = this.balance - 0;
            }
        }

        public void AddMoney(double amount)
        {
            double newBalance = this.balance + amount;

            if (amount < 0)
            {
                // Do nothing
            }

            else if (newBalance <= 150)
            {
                this.balance = newBalance;
            }

            else
            {
                this.balance = 150;
            }

        }
    }
}