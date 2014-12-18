using System;
using System.Threading.Tasks;
using SampleClientApp.MyService;

namespace SampleClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        private static async Task Run()
        {
            using (var svc = new MyServiceClient())
            {
                var result = await svc.SumAsync(1, 2);
                Console.WriteLine("Result: " + result);
            }
            Console.ReadLine();
        }
    }
}
