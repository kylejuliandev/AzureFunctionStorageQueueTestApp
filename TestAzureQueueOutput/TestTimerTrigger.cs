using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Shared;

namespace TestAzureQueueOutput
{
    public class TestTimerTrigger
    {
        [FunctionName("TestTimerTrigger")]
        [return: Queue("testqueue", Connection = "ConnectionStrings:QueueStorage")]
        public ProcessStorageQueueCommand Run([TimerTrigger("5/20 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var message = new ProcessStorageQueueCommand
            {
                TriggeredAt = DateTime.Now
            };

            return message;
        }
    }
}
