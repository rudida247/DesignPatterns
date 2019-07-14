using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Watch watch1 = Watch.GetInstance();
            Watch watch2 = Watch.GetInstance();
            Watch watch3 = Watch.GetInstance();

            watch1.printTime();
            watch2.printTime();
            watch3.printTime();
        }
    }
}
