using AutoMapper;
using CodeFirstMvcProject_Arefin.Models;
using CodeFirstMvcProject_Arefin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CodeFirstMvcProject_Arefin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Mapper.Initialize(config =>
            {
                config.CreateMap<ProductVM, Product>();
                config.CreateMap<Product, ProductVM>();
            });
        }
    }
}
