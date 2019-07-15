using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    abstract public class Shape : IProtoType<Shape>
    {
        public Shape()
        {

        }

        public abstract Shape clone();
    }
}
