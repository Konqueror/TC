namespace Banking
{
    abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal rate;

        //Get property for everyone and private set cuz you cant change account's blanace, rate and customer.
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return this.rate;
            }
            private set
            {
                this.rate = value;
            }
        }

        //Constructor
        public Account(Customer customer, decimal balance, decimal rate)
        {
            this.customer = customer;
            this.balance = balance;
            this.rate = rate;
        }

        public virtual decimal CalculateInterest(decimal months)
        {
            if (months > 0)
            {
                return this.Balance * this.rate * months;
            }
            else
            {
                throw new System.ArgumentException("Months cat be < 0");
            } 
        }
    }
}
