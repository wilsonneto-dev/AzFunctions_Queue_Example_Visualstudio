using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("acoes", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            // throw new Exception("err");
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
