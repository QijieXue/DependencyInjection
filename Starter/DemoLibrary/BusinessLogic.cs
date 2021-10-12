using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {

        }

        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Starting the process of data...");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            logger.Log("Finished processing of data.");
            Console.WriteLine();
        }
    }
}
