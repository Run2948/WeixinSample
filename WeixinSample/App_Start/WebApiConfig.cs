using System.Web.Http;

namespace WeixinSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "WeixinApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "WeixinService", action = "Get", id = RouteParameter.Optional }
            );
        }
    }
}
