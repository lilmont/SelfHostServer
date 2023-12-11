using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostServer.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Server Config
            var config = new HttpSelfHostConfiguration("http://localhost:7777"); ;
            config.Routes.MapHttpRoute("Default",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            //Init Server
            HttpSelfHostServer server = new HttpSelfHostServer(config);
            //Listen
            server.OpenAsync().Wait();
            //Blocking Code
            Console.ReadLine();
        }
    }
}
