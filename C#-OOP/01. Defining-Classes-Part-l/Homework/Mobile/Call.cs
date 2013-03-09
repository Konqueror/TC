using System;

namespace Mobile
{
    class Call
    {
        //Fields
        private DateTime date;
        private DateTime time;
        private string dialedNumber;
        private ushort duration;
        ////////// Lets add some Properties ////////// 
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }

        public ushort Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
        //Constructor
        public Call(DateTime date, DateTime time, string dialedNumber, ushort duration)
        {
            this.Time = time; 
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
    }
}
