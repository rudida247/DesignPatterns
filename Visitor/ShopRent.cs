using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ShopRent : IVisitable
    {
        public double Price;

        public ShopRent(double price)
        {
            Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Shop rent price: {Price}";
        }
    }
}
