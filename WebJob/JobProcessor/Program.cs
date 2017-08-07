using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage;
using Microsoft.ServiceBus.Messaging;
using System.Configuration;

namespace JobProcessor
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            string iotHubConnectionString = ConfigurationManager.ConnectionStrings["Microsoft.Azure.IoT.ConnectionString"].ToString();
            string iotHubD2cEndpoint = "messages/events";
            string strGroupName = ConfigurationManager.AppSettings["GroupName"].ToString();
            IoTProcessor.StorageConnectionString = ConfigurationManager.ConnectionStrings["Microsoft.Azure.IoT.Storage.ConnectionString"].ToString();
            string strContainerName = ConfigurationManager.AppSettings["ContainerName"].ToString();

            string eventProcessorHostName = Guid.NewGuid().ToString();
            EventProcessorHost eventProcessorHost = 
                new EventProcessorHost(eventProcessorHostName, iotHubD2cEndpoint, strGroupName, 
                iotHubConnectionString, IoTProcessor.StorageConnectionString, strContainerName);

            eventProcessorHost.RegisterEventProcessorAsync<IoTProcessor>().Wait();
            eventProcessorHost.UnregisterEventProcessorAsync().Wait();
        }
    }
}
