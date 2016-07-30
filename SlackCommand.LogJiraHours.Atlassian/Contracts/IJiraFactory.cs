using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atlassian.Jira;
using SlackCommand.LogJiraHours.Atlassian.Request;

namespace SlackCommand.LogJiraHours.Atlassian.Contracts
{
    public interface IJiraFactory
    {
        Jira GetJiraInstance(UserData jiraUser);
    }
}
