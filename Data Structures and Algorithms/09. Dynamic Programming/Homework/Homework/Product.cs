using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Product
    {
        string name;
        int weigth;
        int cost;

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

        public int Weigth
        {
            get
            {
                return this.weigth;
            }
            set
            {
                this.weigth = value;
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }
        }

        public Product(string name, int weight, int cost)
        {
            this.Name = name;
            this.Weigth = weight;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return this.Name + " - Cost: "+ this.Cost;
        }
    }
}
