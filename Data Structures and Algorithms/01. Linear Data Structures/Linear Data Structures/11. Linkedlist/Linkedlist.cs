using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class Linkedlist<T>
    {
        ListItem<T> firstElement;

        public ListItem<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }
            set
            {
                this.firstElement = value;
            }
        }

        private ListItem<T> lastAdded = null;

        public Linkedlist(T firstElement)
        {
            ListItem<T> newNode = new ListItem<T>();
            newNode.Value = firstElement;
            newNode.NextItem = null;
            lastAdded = newNode;
            this.FirstElement = newNode;
        }

        public void AddNode(T element)
        {
            ListItem<T> newNode = new ListItem<T>();
            newNode.Value = element;
            newNode.NextItem = null;
            lastAdded.NextItem = newNode;
            this.lastAdded = newNode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            var currentItem = this.FirstElement;

            while(currentItem != null)
            {
                result.Append(currentItem.Value + ", ");
                currentItem = currentItem.NextItem;
            }

            return result.ToString();
        }
    }
}
