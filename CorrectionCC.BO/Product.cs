using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCC.BO
{
    public class Product
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
       
        public Product()
        {

        }
        public  Product(string Reference,string Name, double Price)
        {
            this.Price = Price;
            this.Name = Name;
            this.Reference = Reference;
        }
        public Product(Product prod):this(prod?.Reference, prod?.Name, prod?.Price??0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
