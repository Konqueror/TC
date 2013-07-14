using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class ListItem<T> 
    {
        T value;
        ListItem<T> nextItem;

        public ListItem<T> NextItem
        {
            get
            {
                return this.nextItem;
            }
            set
            {
                this.nextItem = value;
            }
        }
        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

    }
}
