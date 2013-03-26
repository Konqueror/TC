namespace Banking
{
    struct Customer
    {
        private CustomerType customerType;

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
        }

        public Customer(CustomerType customerType)
        {
            this.customerType = customerType;
        }

    }
}
