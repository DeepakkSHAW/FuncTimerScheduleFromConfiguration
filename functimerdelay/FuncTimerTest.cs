using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace functimerdelay
{
    public static class FuncTimerTest
    {
        [FunctionName("TimerTest")]
        //***Reading Schedule Timer time from Configuration File***//
        public static void Run([TimerTrigger("%TimerScheduleAppSetting%")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            if (myTimer.IsPastDue)
            {
                log.LogInformation("Timer is running late!");
            }
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
