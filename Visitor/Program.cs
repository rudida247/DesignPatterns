using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");
            IVisitor oneShakelSale = new OneShekelSale();
            ShopRent shopRent = new ShopRent(4000);
            Console.WriteLine(shopRent);
            Console.WriteLine($"Price after sale = {shopRent.Accept(oneShakelSale)}");
            Console.ReadLine();

        }
    }
}
