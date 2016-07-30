using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace SlackCommand.LogJiraHours.WebApi.App_Start
{
    public class IoCConfig
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            RegisterApiControllers(builder);
            IoCRegisterDependencies.RegisterOtherDependencies(builder);

            var container = builder.Build();
            ResolverApiControllers(container);

            return container;
        }

        private static void RegisterApiControllers(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }

        private static void ResolverApiControllers(IContainer iContainer)
        {
            var resolver = new AutofacWebApiDependencyResolver(iContainer);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

    }
}