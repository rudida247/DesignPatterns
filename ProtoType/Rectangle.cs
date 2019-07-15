using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Rectangle : Shape
    {

        public Point one { get; set; }
        public Point two { get; set; }
        public Point three { get; set; }
        public Point four { get; set; }

        public Rectangle(Point one, Point two, Point three, Point four)
        {
            this.one = one;
            this.two = two;
            this.three = three;
            this.four = four;
        }
        public override string ToString()
        {
            return $"Rectangle Point one :{one}, Point two :{two} , Point three:{three}, Point four: {four}";
        }

        public override Shape clone()
        {
            return new Rectangle((Point)one.clone(), (Point)two.clone(), (Point)three.clone(), (Point)four.clone());
        }
    }
}
