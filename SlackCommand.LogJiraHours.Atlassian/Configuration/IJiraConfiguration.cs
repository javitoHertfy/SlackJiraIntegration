using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackCommand.LogJiraHours.Atlassian.Configuration
{
    public interface IJiraConfiguration
    {
        string JiraWorklogEnpoint {get;}
        string JiraBaseUrl { get; }
        Dictionary<string, string> UserAuthentication { get; }

    }
}
