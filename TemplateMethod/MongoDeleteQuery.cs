using System;

namespace TemplateMethodPro
{
    public class MongoDeleteQuery:MongoTemplateBase
    {
        
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Delete table in MongoDB .....");
        }
    }
}