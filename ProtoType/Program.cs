using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(new Point(5, 5), 50.5));
            shapes.Add(new Circle(new Point(4, 5), 20));
            shapes.Add(new Rectangle(new Point(2, 5), new Point(3, 5), new Point(4, 5), new Point(5, 5)));
            ShapeHolder shapeHolder = new ShapeHolder(shapes);

            Console.WriteLine(shapeHolder);
            ShapeHolder shapeHolder2 = shapeHolder.clone();

            DoStuffWithShapeHolder(shapeHolder2);
            Console.WriteLine(shapeHolder2);
            Console.WriteLine(shapeHolder);
            Console.ReadLine();
        }

        public static void DoStuffWithShapeHolder(ShapeHolder shapeHolder)
        {
            shapeHolder.shapes.Remove(shapeHolder.shapes.First());
        }
    }
}
