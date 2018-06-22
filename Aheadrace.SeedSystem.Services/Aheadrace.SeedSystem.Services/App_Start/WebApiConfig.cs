using Aheadrace.SeedSystem.Business;
using Aheadrace.SeedSystem.Business.Contracts;
using Aheadrace.SeedSystem.Facade;
using Aheadrace.SeedSystem.Facade.Contracts;
using Aheadrace.SeedSystem.Repository;
using Aheadrace.SeedSystem.Repository.Contracts;
using Aheadrace.SeedSystem.Services.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace Aheadrace.SeedSystem.Services
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
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();
            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Admin.IAdminFacade, Aheadrace.SeedSystem.Facade.Admin.AdminFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Admin.IAdminBLL, Aheadrace.SeedSystem.Business.Admin.AdminBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Admin.IAdminRepository, Aheadrace.SeedSystem.Repository.Admin.AdminRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Common.Location.ILocationFacade, Aheadrace.SeedSystem.Facade.Common.Location.LocationFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Common.Location.ILocationBLL, Aheadrace.SeedSystem.Business.Common.Location.LocationBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Common.Location.ILocationRepository, Aheadrace.SeedSystem.Repository.Common.Location.LocationRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Home.IHomeFacade, Aheadrace.SeedSystem.Facade.Home.HomeFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Home.IHomeBLL, Aheadrace.SeedSystem.Business.Home.HomeBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Home.IHomeRepository, Aheadrace.SeedSystem.Repository.Home.HomeRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Login.ILoginFacade, Aheadrace.SeedSystem.Facade.Login.LoginFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Login.ILoginBLL, Aheadrace.SeedSystem.Business.Login.LoginBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Login.ILoginRepository, Aheadrace.SeedSystem.Repository.Login.LoginRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Products.IProductsFacade, Aheadrace.SeedSystem.Facade.Products.ProductsFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Products.IProductsBLL, Aheadrace.SeedSystem.Business.Products.ProductsBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Products.IProductRepository, Aheadrace.SeedSystem.Repository.Products.ProductsRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Aheadrace.SeedSystem.Facade.Contracts.Users.IUserFacade, Aheadrace.SeedSystem.Facade.Users.UserFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Business.Contracts.Users.IUserBLL, Aheadrace.SeedSystem.Business.Users.UserBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Aheadrace.SeedSystem.Repository.Contracts.Users.IUserRepository, Aheadrace.SeedSystem.Repository.Users.UsersRepository>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
