using System;
using DemoLibrary;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            businessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
