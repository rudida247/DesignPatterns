using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        private string Name;
        private int ID;

        public ClientData(string name, int iD)
        {
            Name = name;
            ID = iD;
        }

        public override string ToString()
        {
            return $"Client Data: Name - {Name}, ID - {ID}";
        }
    }
}
