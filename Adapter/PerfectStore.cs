using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PerfectStore : IDBData
    {
        public void Store(ClientData clientData)
        {
            Console.WriteLine("Store is perfect! " + clientData.ToString());
        }
    }
}
