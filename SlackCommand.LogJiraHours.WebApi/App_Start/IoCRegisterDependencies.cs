using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using SlackCommand.LogJiraHours.WebApi.Configuration;

namespace SlackCommand.LogJiraHours.WebApi.App_Start
{
    public class IoCRegisterDependencies
    {
        public static void RegisterOtherDependencies(ContainerBuilder builder)
        {
            var modules = new List<Module>
            { 
               
               new SlackCommand.LogJiraHours.Atlassian.IoC.IoCModule()
            };

            foreach (var module in modules)
                builder.RegisterModule(module);
            RegisterConfiguration(builder);


        }

        private static void RegisterConfiguration(ContainerBuilder builder)
        {
            builder.RegisterType<SlackBotConfiguration>().As<ISlackBotConfiguration>();
    
        }

    }
}