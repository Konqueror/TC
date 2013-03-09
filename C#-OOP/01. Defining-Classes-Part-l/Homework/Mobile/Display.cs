using System;

namespace Mobile
{
    class Display
    {
        //Fields
        private int? size;
        private int? colorsNumber;
        ////////// Lets add some Properties ////////// 
        public int? Size
        {
            get { return this.size; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? ColorsNumber
        {
            get { return this.colorsNumber; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == null)
                {
                    this.colorsNumber = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        //Counstructor
        public Display(int? size, int? numberOfColors)
        {
            this.size = size;
            this.ColorsNumber = numberOfColors;
        }
    }
}