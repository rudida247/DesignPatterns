﻿using System;

namespace TemplateMethodPro
{
    public abstract class MongoTemplateBase : TemplateQueryRunner
    {
        protected override void CreateDbConnection()
        {
            Console.WriteLine("Creating Mongo connection ... ");
        }
        protected override void OpenDbConnection()
        {
            Console.WriteLine("Opening Mongo connection ... ");
        }
        protected override void CloseDbConnection()
        {
            Console.WriteLine("Closing Mongo connection ... ");
        }
    }
}