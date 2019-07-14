using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Watch
    {
        private static Watch INSTANCE = new Watch();
        private static object locked = new object();
        private Watch()
        {

        }
        public static Watch GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }
            lock (locked)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Watch();
                }
            }
      

            return INSTANCE;
        }
        
        public void printTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
