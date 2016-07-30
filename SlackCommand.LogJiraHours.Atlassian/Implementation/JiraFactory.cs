using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackCommand.LogJiraHours.Atlassian.Configuration;
using SlackCommand.LogJiraHours.Atlassian.Contracts;
using Atlassian.Jira;
using SlackCommand.LogJiraHours.Atlassian.Request;

namespace SlackCommand.LogJiraHours.Atlassian.Implementation
{
    public class JiraFactory : IJiraFactory
    {
        
        protected readonly IJiraConfiguration iJiraConfiguration;

        public JiraFactory(IJiraConfiguration iJiraConfiguration)
        {
            if (iJiraConfiguration == null)
                throw new ArgumentNullException("iJiraConfiguration");
           
             this.iJiraConfiguration = iJiraConfiguration;
                          
        }    

        public Jira GetJiraInstance(UserData jiraUser)
        {
            // create a connection to JIRA using the Rest client
            return Jira.CreateRestClient(iJiraConfiguration.JiraBaseUrl, jiraUser.UserName, jiraUser.Password);

        }      

    }
}
