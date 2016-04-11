using System.Web.Mvc;

namespace WebAppSupportSystem.Areas.Default
{
    public class DefaultAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Default";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            /*context.MapRoute(
                "_Default_default",
                "_Default/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );*/
            context.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebAppSupportSystem.Areas.Default.Controllers" }
            );
        }
    }
}
