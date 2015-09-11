using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5WebJobTest.WebJob {
    public class Program {
        public void Main(string[] args) {
            var host = new JobHost(new JobHostConfiguration("DefaultEndpointsProtocol=https;AccountName=th2g;AccountKey=fxtfLwgXyT1ZCokLmUWhLgEIofxmSXQGGIgHxq8pH0stVLq+WqjPZgr8JjXzSdKrfoGS7r4aS8JhD0SJN4Fv5w=="));
            host.RunAndBlock();
        }
    }
}
