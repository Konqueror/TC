namespace People
{
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        //Constructor
        public Worker(string fistName, string secondName, int weekSalary, int workHoursPerDay)
            :base(fistName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5.0);
        }

        //override ToString for easy testing and yes StringBulder is faster for bigger strings
        public override string ToString()
        {
            return FirstName + " " + SecondName + " " + MoneyPerHour();
        }
    }
}
