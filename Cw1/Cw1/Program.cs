using System;
using System.Net.Http;
using System.Text.RegularExpressions;
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
            //Console.WriteLine(respone.Content.ReadAsStringAsync());
            var content = await respone.Content.ReadAsStringAsync();
            Regex regex = new Regex(@"[a-zA-z0-9.]+\@[a-zA-Z0-9.]+\.[a-zA-Z0-9.]+");
            MatchCollection matcher = regex.Matches(content);
            foreach (Match match in matcher)
            {
                Console.WriteLine(match);
            }
        }
    }
}
