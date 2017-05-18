using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Owin;

[assembly: OwinStartup(typeof(SignalRTest.Startup))]

namespace SignalRTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new StringEnumConverter());
            // Register the serializer.
            GlobalHost.DependencyResolver.Register(typeof(JsonSerializer), () => serializer);

            app.MapSignalR();
        }
    }
}
