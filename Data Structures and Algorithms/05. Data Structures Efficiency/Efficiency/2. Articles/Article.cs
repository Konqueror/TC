using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public class Article : IComparable<Article>
    {
        public string Title { get; private set; }
        public uint Price { get; private set; }
        public string Vendor { get; private set; }
        public long Barcode { get; private set; }


        public Article(string title, uint price, string vendor, long barcode)
        {
            this.Title = title;
            this.Price = price;
            this.Vendor = vendor;
            this.Barcode = barcode;
        }

        public int CompareTo(Article other)
        {
            return string.Compare(this.Title, other.Title);
        }

        public override string ToString()
        {
            return this.Title + " " + this.Price;
        }
    }
}