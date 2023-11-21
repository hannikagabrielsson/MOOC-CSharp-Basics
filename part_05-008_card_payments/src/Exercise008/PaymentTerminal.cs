namespace Exercise008
{
    public class PaymentTerminal
    {
        public double money { get; private set; }  // amount of cash
        public int coffeeAmount { get; private set; } // number of sold coffees
        public int lunchAmount { get; private set; }  // number of sold lunches

        public PaymentTerminal()
        {
            this.money = 1000;
            this.coffeeAmount = 0;
            this.lunchAmount = 0;
            // register initially has 1000 euros of money
        }

        public double DrinkCoffee(double payment)
        {
            double change = 0;
            double coffee = 2.50;
            if (payment >= coffee)
            {
                change = payment - coffee;
                this.money = this.money + coffee;
                this.coffeeAmount++;
                return change;
            }

            else
            {
                return payment;
            }
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment

        }

        public double EatLunch(double payment)
        {
            double change = 0;
            double lunch = 10.30;
            if (payment >= lunch)
            {
                change = payment - lunch;
                return change;
                this.money = this.money + lunch;
                this.lunchAmount++;
            }

            else
            {
                return payment;
            }
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
        }


        public bool DrinkCoffee(PaymentCard card)
        {
            double coffee = 2.50;
            if (card.balance >= coffee)
            {
                card.balance = card.balance - coffee;
                return true;
            }
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            return false;
        }

        public bool EatLunch(PaymentCard card)
        {
            double lunch = 10.30;
            if (card.balance >= lunch)
            {
                card.balance = card.balance - lunch;
                return true;
            }

            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            else
            {
                return false;
            }
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            if (sum > 0)
            {
                card.balance = card.balance + sum;
                this.money = this.money + sum;
            }

            else
            {
                card.balance = card.balance;
            }
            // Only add positive amounts
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}