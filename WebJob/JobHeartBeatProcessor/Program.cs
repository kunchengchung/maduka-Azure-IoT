﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace JobHeartBeatProcessor
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            Console.WriteLine("Start Time:" + DateTime.UtcNow.ToString());
            HeartBeatProcessor.Process().Wait();
            Console.WriteLine("Stop Time:" + DateTime.UtcNow.ToString());
        }
    }
}
