using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AngularWithWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{id}",
             defaults: new { id = RouteParameter.Optional }
         );
            config.Routes.MapHttpRoute(
                name: "GetAllEmplyee",
                routeTemplate: "api/Employee",
                defaults: new { Controllers = "Employee", action = "GetAllEmployee", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                  name: "GetAllEmplyeeById",
                  routeTemplate: "api/Employee/0",
                  defaults: new { Controllers = "Employee", action = "GetEmployeeById", id = RouteParameter.Optional }
              );
            config.Routes.MapHttpRoute(
                name: "PostEmplyee",
                routeTemplate: "api/Employee/PostEmployeSave",
                defaults: new { Controllers = "Employee", action = "PostEmployeSave"}
            );
            config.Routes.MapHttpRoute(
                name: "EditEmplyee",
                routeTemplate: "api/Employee/PostEmployeeEdit/0/0/0/0",
                defaults: new { Controllers = "Employee", action = "PostEmployeeEdit" }
            );
            config.Routes.MapHttpRoute(
                 name: "DeleteAllEmplyee",
                 routeTemplate: "api/Employee/DeleteEmployee/0/0",
                 defaults: new { Controllers = "Employee", action = "DeleteEmployee", id = RouteParameter.Optional }
             );
        }
    }
}
