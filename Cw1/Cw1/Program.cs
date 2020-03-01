using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Uri siteUri = new Uri(args[0]);
            var httpClient = new HttpClient();
            var respone = await httpClient.GetAsync(siteUri);
            Console.WriteLine("Hello World!");
            Console.WriteLine(respone.Headers);
        }
    }
}
