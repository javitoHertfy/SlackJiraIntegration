using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlackCommand.LogJiraHours.WebApi.Configuration
{
    public interface ISlackBotConfiguration
    {
        string SlackToken { get; }
    }
}