using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackCommand.LogJiraHours.Atlassian.Configuration;
using SlackCommand.LogJiraHours.Atlassian.Contracts;
using SlackCommand.LogJiraHours.Atlassian.Request;

namespace SlackCommand.LogJiraHours.Atlassian.Implementation
{
    public class UserTranslationService :IUserTranslationService
    {
        protected readonly IJiraConfiguration iJiraConfiguration;

        public UserTranslationService(IJiraConfiguration iJiraConfiguration)
        {
            if (iJiraConfiguration == null)
                throw new ArgumentNullException("iJiraConfiguration");

            this.iJiraConfiguration = iJiraConfiguration;
        }

        public Request.UserData GetJiraName(string name)
        {
            UserData jiraUser = new UserData(iJiraConfiguration.UserAuthentication[name]);
            return jiraUser;
        }       
    }
}
