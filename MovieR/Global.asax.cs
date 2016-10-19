using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;


namespace MovieR
{
	public class Global : HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			RegisterGlobalFilters(GlobalFilters.Filters);


		}
	}
}

