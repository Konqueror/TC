using System;
using System.Text;
using System.Collections.Generic;

namespace Mobile
{
    public class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static bool iPhone4s;
        private List<Call> CallHistory = new List<Call>();
        ////////// Lets add some Properties ////////// 
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

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == null))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? Price
        {
            get { return this.price; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == null))
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public static bool IPhone4s
        {
            get { return iPhone4s; }
            set
            {
                iPhone4s = value;
            }
        }

        // Full Constructor
        public GSM(string model, string manufacturer, int? price, string owner, string batteryModel, int? hoursIdle,
        int? hoursTalk, BatteryTypes batteryType, int? size, int? numberOfColors)
            {
                this.Model = model;
                this.Manufacturer = manufacturer;
                this.Price = price;
                this.Owner = owner;
                this.battery = new Battery(batteryModel, hoursIdle, hoursTalk, batteryType);
                this.display = new Display(size, numberOfColors);
            }
        // Part Constructor
        public GSM(string model, string manufacturer, int? price,  BatteryTypes batteryModel)
            : this(model, manufacturer, price, null, null, null, null, batteryModel, null, null)
        {
        }
        // Override ToString(). I am using StringBulder to return string faster!
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Model: ").Append(Model).Append("\nPrice: ").Append(Price).Append("\nBattery: ").Append(battery.Type);
            // Ok i got the point that is borring!
            return result.ToString();
        }

        //Call History Methods//
        public void AddCall(DateTime date, DateTime time, string dialedNumber, ushort duration)
        {
            CallHistory.Add(new Call(date, time, dialedNumber, duration));
        }

        public void DeleteCall(string dialedNumber)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].DialedNumber.Equals(dialedNumber))
                {
                    CallHistory.RemoveAt(i);
                }
            }
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            decimal priceResult = 0;

            foreach (var call in CallHistory)
            {
                priceResult += ((decimal)call.Duration / 60) * pricePerMinute;
            }

            return priceResult;
        }

        public string CallHisotryToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var call in CallHistory)
            {
                result.Append("\nDuration: ").Append(call.Duration).Append("\nNumber: ").Append(call.DialedNumber);
            }

            return result.ToString();
        }
    }
}
