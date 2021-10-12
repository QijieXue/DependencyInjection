using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace DependencyInjectionDemo
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
