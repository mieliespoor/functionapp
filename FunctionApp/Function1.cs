using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("queueitem", Connection = "AzureWebJobsDashboard")]string myQueueItem, ILogger logger)
        {
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
