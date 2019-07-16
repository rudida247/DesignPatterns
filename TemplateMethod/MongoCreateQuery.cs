using System;

namespace TemplateMethodPro
{
    public class MongoCreateQuery:MongoTemplateBase
    { 
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Create new table in  MongoDB .....");
        }
    }
}