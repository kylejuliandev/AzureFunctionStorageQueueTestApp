using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Shared;

namespace TestAzureQueueInput
{
    public static class TestQueueTrigger
    {
        [FunctionName("TestQueueTrigger")]
        public static void Run([QueueTrigger("testqueue", Connection = "ConnectionStrings:QueueStorage")]ProcessStorageQueueCommand myQueueItem, 
            ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem.TriggeredAt}");
        }
    }
}
