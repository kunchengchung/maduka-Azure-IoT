using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage;
using Microsoft.ServiceBus.Messaging;

namespace JobProcessor
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            string iotHubConnectionString = "[IoT Hub連接字串]";
            string iotHubD2cEndpoint = "messages/events";
            string strGroupName = "[取用者群組的名稱]";
            IoTProcessor.StorageConnectionString = "[儲存體的連接字串]";
            // IoTProcessor.ServiceBusConnectionString = "[ServiceBus連線字串]";
            // IoTProcessor.DatabaseConnectString = "[資料庫連線字串]";
            string strBlobName = "messages-events";

            string eventProcessorHostName = Guid.NewGuid().ToString();
            EventProcessorHost eventProcessorHost = 
                new EventProcessorHost(eventProcessorHostName, iotHubD2cEndpoint, strGroupName, 
                iotHubConnectionString, IoTProcessor.StorageConnectionString, strBlobName);

            eventProcessorHost.RegisterEventProcessorAsync<IoTProcessor>().Wait();
            eventProcessorHost.UnregisterEventProcessorAsync().Wait();
        }
    }
}
