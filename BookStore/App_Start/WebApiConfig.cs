using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Tracing;

namespace BookStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();
            // Configuration et services API Web
            //config.EnableSystemDiagnosticsTracing();

            SystemDiagnosticsTraceWriter traceWriter = config.EnableSystemDiagnosticsTracing();
            traceWriter.IsVerbose = true;
            traceWriter.MinimumLevel = TraceLevel.Warn;
        
            config.Routes.MapHttpRoute(
                name: "MyApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
