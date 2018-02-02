[assembly: WebActivator.PostApplicationStartMethod(typeof(NeonServer.WebAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace NeonServer.WebAPI.App_Start
{
    using System.Web.Http;
    using NeonServer.Infraestrutura.Repository;
    using NeonServer.Infraestrutura.Repository.Interface;
    using NeonServer.Service.Service;
    using NeonServer.Service.Service.Interface;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {

           container.Register<IClientRepository, ClientRepository>(Lifestyle.Scoped);
            container.Register<IClientService, ClientService>(Lifestyle.Scoped);
        }
    }
}