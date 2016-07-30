using System;
using System.IO;
using System.Net;
using System.Text;
using SlackCommand.LogJiraHours.Atlassian.Configuration;
using SlackCommand.LogJiraHours.Atlassian.Contracts;
using SlackCommand.LogJiraHours.Atlassian.Request;
using Atlassian.Jira;

namespace SlackCommand.LogJiraHours.Atlassian.Implementation
{
    public class JiraService : IJiraService
    {
        protected readonly IJiraConfiguration iJiraConfiguration;
        protected readonly IJiraFactory iJiraFactory;        

        public JiraService(IJiraConfiguration iJiraConfiguration, IJiraFactory iJiraFactory)
        {
            if (iJiraConfiguration == null)
                throw new ArgumentNullException("iJiraConfiguration");

            this.iJiraConfiguration = iJiraConfiguration;

            if (iJiraFactory == null)
                throw new ArgumentNullException("iJiraFactory");

            this.iJiraFactory = iJiraFactory;

         

        }

        public bool WorkLog(UserData jiraUser, string issueId, string timeSpent)
        {

            var jiraService = this.iJiraFactory.GetJiraInstance(jiraUser);
            Issue issue = jiraService.Issues.GetIssueAsync(issueId).Result;

            //// add a worklog
            issue.AddWorklog(timeSpent);
            return true;


        }

    }




}


