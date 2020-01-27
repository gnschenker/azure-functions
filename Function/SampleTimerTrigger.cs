using System;
using Function.Model;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace functions
{
    public static class SampleTimerTrigger
    {
        [FunctionName("SampleTimerTrigger")]
        public static void Run([TimerTrigger("00:00:10")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var options = new DbContextOptionsBuilder<HobbiesContext>()
            using(var context = new HobbiesContext())
            {

            }
        }
    }
}
