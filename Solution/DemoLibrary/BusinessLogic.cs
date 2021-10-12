using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the process of data...");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            _logger.Log("Finished processing of data.");
            Console.WriteLine();
        }
    }
}
