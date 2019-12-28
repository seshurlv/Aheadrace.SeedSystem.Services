using Aheadrace.SeedSystem.Services.Container;
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
            container.RegisterType<Facade.Contracts.Admin.IAdminFacade, Facade.Admin.AdminFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Admin.IAdminBLL, Business.Admin.AdminBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Admin.IAdminRepository, Repository.Admin.AdminRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Facade.Contracts.Common.Location.ILocationFacade, Facade.Common.Location.LocationFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Common.Location.ILocationBLL, Business.Common.Location.LocationBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Common.Location.ILocationRepository, Repository.Common.Location.LocationRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Facade.Contracts.Home.IHomeFacade, Facade.Home.HomeFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Home.IHomeBLL, Business.Home.HomeBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Home.IHomeRepository, Repository.Home.HomeRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Facade.Contracts.Login.ILoginFacade, Facade.Login.LoginFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Login.ILoginBLL, Business.Login.LoginBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Login.ILoginRepository, Repository.Login.LoginRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Facade.Contracts.Products.IProductsFacade, Facade.Products.ProductsFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Products.IProductsBLL, Business.Products.ProductsBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Products.IProductRepository, Repository.Products.ProductsRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<Facade.Contracts.Users.IUserFacade, Facade.Users.UserFacade>(new HierarchicalLifetimeManager());
            container.RegisterType<Business.Contracts.Users.IUserBLL, Business.Users.UserBLL>(new HierarchicalLifetimeManager());
            container.RegisterType<Repository.Contracts.Users.IUserRepository, Repository.Users.UsersRepository>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
