﻿namespace ExperienceGenerator.Exm
{
  using System.Web.Http;
  using ExperienceGenerator.Exm.Services;

  public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            JobManager.Instance = new JobManager();

            config.Routes.MapHttpRoute(
                name: "ExperienceGeneratorExmJobsApi",
                routeTemplate: "api/xgen/exmjobs/{action}/{id}",
                defaults: new {controller = "ExmJobs",  id = RouteParameter.Optional}
                );
            config.Routes.MapHttpRoute(
                name: "ExperienceGeneratorExmEventsApi",
                routeTemplate: "api/xgen/exmevents/{action}",
                defaults: new {controller = "ExmEvents"}
                );
			config.Routes.MapHttpRoute(
				name: "ExmActionsApi",
				routeTemplate: "api/xgen/exmactions/{action}/{id}",
				defaults: new { controller = "ExmActions", id = RouteParameter.Optional }
				);
		}
    }
}
