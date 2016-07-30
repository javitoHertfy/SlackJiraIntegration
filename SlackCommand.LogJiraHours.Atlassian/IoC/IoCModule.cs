using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SlackCommand.LogJiraHours.Atlassian.Configuration;
using SlackCommand.LogJiraHours.Atlassian.Contracts;
using SlackCommand.LogJiraHours.Atlassian.Implementation;

namespace SlackCommand.LogJiraHours.Atlassian.IoC
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterAppServices(builder);
        }

        protected internal void RegisterAppServices(ContainerBuilder builder)
        {

            builder.RegisterType<JiraConfiguration>().As<IJiraConfiguration>();
            builder.RegisterType<JiraFactory>().As<IJiraFactory>();
            builder.RegisterType<JiraService>().As<IJiraService>();
            builder.RegisterType<UserTranslationService>().As<IUserTranslationService>();
        }
    }
}
