namespace Banking
{
    class DepositAcc : Account
    {
        public DepositAcc(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
        }

        public void DepositMoney(decimal amountOfMoney)
        {
            if (amountOfMoney > 0)
            {
                this.Balance += amountOfMoney;
            }
            else
            {
                throw new System.ArgumentException("You can't deposit negative amout of money");
            }
        }

        public void DrawMoney(decimal amountOfMoney)
        {
            if (amountOfMoney > 0)
            {
                if (amountOfMoney <= this.Balance)
                {
                    this.Balance -= amountOfMoney;
                }
                else
                {
                    throw new System.ArgumentException("You can't draw more money that you have");
                }
            }
            else
            {
                throw new System.ArgumentException("You can't draw negative amout of money");
            }
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
