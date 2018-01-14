using Filesteam;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FileSteamWebServer
{
    public class MvcApplication : System.Web.HttpApplication
    {

        static Server server = new Server
        {
            Services = { FileSteamService.BindService(new FileSteamImpl()) },
            Ports = { new ServerPort("127.0.0.1", 52025, ServerCredentials.Insecure) }
        };

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            server.Start();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            server.ShutdownAsync().Wait();
        }
    }
}
