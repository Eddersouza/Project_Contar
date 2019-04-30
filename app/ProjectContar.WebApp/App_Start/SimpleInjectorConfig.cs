using ProjectContar.IoC;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace ProjectContar.WebApp.App_Start
{
    /// <summary>
    /// Dependency injection configuration.
    /// </summary>
    public class SimpleInjectorConfig
    {
        /// <summary>
        /// Init DI Containers.
        /// </summary>
        public static void InitDI()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            DIModule.InitializeIoc(container, Lifestyle.Scoped);

            //GlobalConfiguration.Configuration.DependencyResolver
            //   = new SimpleInjectorWebApiDependencyResolver(container);

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}