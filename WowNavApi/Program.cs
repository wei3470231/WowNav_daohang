using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace WowNavApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            string listeningHostAndPort;
            if (args.Length != 1)
            {
                Console.WriteLine("特别鸣谢 >>>>> 297771751 <<<<< 大佬的鼎力支持");
                Console.WriteLine("                                             本工具出自群: 11969824 ");
                listeningHostAndPort = "http://localhost:5000";
            }
            else
            {
                listeningHostAndPort = args[0];
            }

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls(listeningHostAndPort);
                });
        }
    }
}
