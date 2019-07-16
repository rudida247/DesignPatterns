using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterWebToNonWeb : IDBWebData
    {
        IDBData perfectStore = new PerfectStore(); 
        public void Store(WebClientData c)
        {
            ClientData clientData = new ClientData(c.Name, c.ID);
            perfectStore.Store(clientData);
        }
    }
}
