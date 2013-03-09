using System;

namespace Mobile
{       
    public enum BatteryTypes
    {
        Lilon, NiMH, NiCd
    }

    class Battery
    {
        //Fields
        private string model;
        private int? hoursIDE;
        private int? hoursTalk;
        private BatteryTypes type;
        public string Model
        {
            get { return this.model; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == null))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public BatteryTypes Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int? HoursIDE
        {
            get { return this.hoursIDE; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == null)
                {
                    this.hoursIDE = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        // Constructor
        public Battery (string batteryModel, int? hoursIdle, int? hoursTalk, BatteryTypes batteryType)
        {
            this.Model = batteryModel;
            this.HoursIDE = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.type = batteryType;
        }
    }
}
