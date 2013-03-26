using System;

namespace InvalidRangeException
{
    class InvalidRangeException<T> : Exception
    {
        private T start;

        private T end;

        public T Start
        {
            get
            {
                return this.start;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
        }

        private static  string message = "Out of Range!";

        public InvalidRangeException(T start, T end, Exception innerException = null)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }

    }
}
