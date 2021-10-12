using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DemoLibrary;
using DemoLibrary.Utilities;

namespace DependencyInjectionDemo
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();

            return builder.Build();
        }

        
    }
}
