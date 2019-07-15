using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class ShapeHolder : IProtoType<ShapeHolder>
    {
        public IList<Shape> shapes;

        public ShapeHolder(IList<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public ShapeHolder clone()
        {
            IList<Shape> cloneShapes = new List<Shape>();
            foreach (var shape in this.shapes)
            {
                cloneShapes.Add(shape.clone());
            }
            return new ShapeHolder(cloneShapes);
        }

        public override string ToString()
        {
            string str  = "";
            foreach(var shape in this.shapes)
            {
                str += shape.ToString() + "\n";
            }
            return str;
        }
    }
}
