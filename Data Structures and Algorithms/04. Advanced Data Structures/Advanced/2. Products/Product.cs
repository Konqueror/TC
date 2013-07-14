using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Products
{
    class Product : IComparable
    {
        string name;
        int price;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Object otherObject)
        {
            Product otherProduct = otherObject as Product;
            if (otherObject == null)
            {
                throw new ArgumentException("Object is not a Product");
            }
            else
            {
                return this.Price.CompareTo(otherProduct.Price);
            }
        }

        public override string ToString()
        {
            return this.Name + this.Price;
        }
    }
}
