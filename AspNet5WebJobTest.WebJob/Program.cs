using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5WebJobTest.WebJob {
    public class Program {
        public void Main(string[] args) {
            var host = new JobHost(new JobHostConfiguration("PutAValidConnectionStringHere"));
            host.RunAndBlock();
        }
    }
}
