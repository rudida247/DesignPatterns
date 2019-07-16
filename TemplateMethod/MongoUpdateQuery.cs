using System;

namespace TemplateMethodPro
{
    public class MongoUpdateQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Update table in MongoDB  .....");
        }
    }
}