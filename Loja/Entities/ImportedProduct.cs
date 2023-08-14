using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities
{
    internal class ImportedProduct : Product
    {
        public double customFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee) : base (name, price) 
        {
            this.customFee = customFee; 
        }

        public override string priceTag()
        {
            return ((base.priceTag() + customFee) + " (Customs fee: ${customFee})"); 
        }
    }
}
