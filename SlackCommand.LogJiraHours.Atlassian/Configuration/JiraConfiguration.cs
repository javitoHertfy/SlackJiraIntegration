using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atlassian.Jira;

namespace SlackCommand.LogJiraHours.Atlassian.Configuration
{
    public class JiraConfiguration :IJiraConfiguration
    {       
        
        private const string jiraWorklogEnpoint = "JiraWorklogEnpointKey";
        private const string jiraBaseUrl = "JiraBaseUrlKey";
        private const string userAuthentication = "UserAuthenticationKey";

        public JiraConfiguration()
        {
     
        }

        public string JiraWorklogEnpoint
        {
            get { return "issue/{0}/worklog"; }
        }

        public string JiraBaseUrl
        {
            get { return "YOUR_ATLASSIAN_URL_HERE"; }
        }

        public Dictionary<string, string> UserAuthentication
        {
            get { return new Dictionary<string, string>() { {"SLACK_NAME", "JIRA_USER:JIRA_PASS"}};}
        }
    }
}
