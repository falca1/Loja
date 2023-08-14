using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufatureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base (name, price)
        {
            this.manufatureDate = manufatureDate;
        }

        public override string priceTag()
        {
            return (
                name
                +" (used) $"
                + price.ToString(CultureInfo.InvariantCulture)
                +" (Manufacture date: "
                + manufatureDate.ToString("dd/MM/yyyy")
                +")");
        }

    }
}
