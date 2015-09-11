using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5WebJobTest.WebJob {
    public class Functions {
        // This function will get triggered/executed when a new message is written on an Azure Queue called testqueue
        public static void ProcessHardwareReport([QueueTrigger("testqueue")] string message, TextWriter log) {
            log.WriteLine(message);
        }
    }
}
