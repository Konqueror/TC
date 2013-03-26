namespace Banking
{
    class MortgagAcc : Account
    {
        public MortgagAcc(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
        }
    
        public void DepositMoney(decimal amountOfMoney)
        {
            if (amountOfMoney > 0)
            {
                base.Balance += amountOfMoney;
            }
            else
            {
                throw new System.ArgumentException("You can't deposit negative amout of money");
            }
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer.Equals(CustomerType.Companies) && months < 12)
            {
                return base.CalculateInterest(months) / 12;
            }
            if (this.Customer.Equals(CustomerType.Individuals) && months < 6)
            {
                return base.CalculateInterest(months) / 6;
            }

            return base.CalculateInterest(months);
        }
    }
}
