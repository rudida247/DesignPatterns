using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    class Program
    {
        static void Main(string[] args)
        {
            new OracleSelectAllQuery().Run();
            new MongoCreateQuery().Run();
            new MongoUpdateQuery().Run();
            new MongoDeleteQuery().Run();

            Console.WriteLine();

            new OracleUpdateQuery().Run();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
