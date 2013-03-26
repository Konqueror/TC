namespace Banking
{
    class LoanAcc : Account
    {
        public LoanAcc(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
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

        public override decimal CalculateInterest(decimal months)
        {
            if ((this.Customer.Equals(CustomerType.Individuals) && months < 3) || (this.Customer.Equals(CustomerType.Companies) && months < 2))
            {
                return 0 ;
            }
            return base.CalculateInterest(months);
        }
    }
}
