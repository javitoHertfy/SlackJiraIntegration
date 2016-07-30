using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackCommand.LogJiraHours.Atlassian.Request;

namespace SlackCommand.LogJiraHours.Atlassian.Contracts
{
    public interface IJiraService
    {
        bool WorkLog(UserData jiraUser, string issueId, string timeSpent);
    }
}
