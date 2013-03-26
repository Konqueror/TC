//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _3.BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public ulong Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                this.number = value;
            }
        }
        // Constructor
        public BitArray64(ulong number)
        {
            this.Number = number;
        }
        // Change and get bits
        public int this[int key]
        {
            get
            {
                //check if key is in range of [1:62]
                if (key < 0 || key > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //Get the bit on the position fast! 
                if (((ulong)(1 << key) & this.Number) > 0)
                    return 1;
                else
                    return 0;
            }
            set
            {
                //check if key is in range of [1:62]
                if (key < 0 || key > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //Set a bit to a position!
                if (value == 1)
                {
                    this.number = this.number | (ulong)(1 << key);
                }
                else
                {
                    this.number = this.number & (ulong)((~1) << key);
                }
            }

        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //WTF is the idea here?
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 tempNumber = (obj as BitArray64);

            if ((object)number == null)
            {
                return false;
            }
            else
            {
                return this.number.Equals(tempNumber.number);
            }
        }

        public static bool operator ==(BitArray64 first, object second)
        {
            if (first.number.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BitArray64 first, object second)
        {
            if (!first.number.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
