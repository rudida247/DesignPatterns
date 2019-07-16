using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBWebData adapter = new AdapterWebToNonWeb();
            WebClientData webClientData = new WebClientData("google.com", 145, "172.217.4.78", true);
            StoreClient(adapter, webClientData);
            Console.ReadKey(); 
        }
        
        static void StoreClient(IDBWebData d,WebClientData c)
        {
            d.Store(c);
        }
    }
}
