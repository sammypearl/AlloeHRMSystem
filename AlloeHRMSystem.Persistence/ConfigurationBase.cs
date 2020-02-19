//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AlloeHRMSystem.Persistence
//{
//    public abstract class ConfigurationBase
//    {

//        protected IConfigurationRoot GetConfiguration()
//        {
//            return new ConfigurationBuilder()
//                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//                .AddJsonFile("appsettings.Json")
//                .Build();

//        }

//        protected void RaiseValueNotFoundException(string configurationKey)
//        {
//            throw new Exception($"appsettings key ({configurationKey}) could not be found");
//        }
//    }
//}
