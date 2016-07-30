using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using SlackCommand.LogJiraHours.WebApi.Configuration;
using SlackCommand.LogJiraHours.WebApi.Requests;
using RestSharp;
using SlackCommand.LogJiraHours.Atlassian.Contracts;
using SlackCommand.LogJiraHours.Atlassian.Request;

namespace SlackCommand.LogJiraHours.WebApi.Controllers
{
    public class SlackController : ApiController
    {
        protected readonly ISlackBotConfiguration iSlackBotConfiguration;
        protected readonly IJiraService iJiraService;
        protected readonly IUserTranslationService iUserTranslationService;

        public SlackController(IJiraService iJiraService, ISlackBotConfiguration iSlackBotConfiguration, IUserTranslationService iUserTranslationService)
        {
            if (iSlackBotConfiguration == null)
                throw new ArgumentNullException("iSlackBotConfiguration");

            this.iSlackBotConfiguration = iSlackBotConfiguration;
            if (iJiraService == null)
                throw new ArgumentNullException("iJiraService");

            this.iJiraService = iJiraService;
            if (iUserTranslationService == null)
                throw new ArgumentNullException("iUserTranslationService");

            this.iUserTranslationService = iUserTranslationService;
         
        }
        /// <summary>
        // token=gIkuvaNzQIHg97ATvDxqgjtO
        //team_id=T0001
        //team_domain=example
        //channel_id=C2147483705
        //channel_name=test
        //user_id=U2147483697
        //user_name=Steve
        //command=/weather
        //text=94070
        //response_url=https://hooks.slack.com/commands/1234/5678
        /// </summary>        
        [HttpPost]        
        public IHttpActionResult SlackCommand(SlackRequest slackRequest)
        {
            if (slackRequest.token != iSlackBotConfiguration.SlackToken)
            {
                return Unauthorized();
            }
            else
            {
                try
                {
                    var slackCommand = DecomposeTextCommand(slackRequest.text);
                    UserData jiraUser = iUserTranslationService.GetJiraName(slackRequest.user_name);

                    bool result = iJiraService.WorkLog(jiraUser, slackCommand[0], slackCommand[1]);

                    if (result)
                    {
                        return Ok(string.Format("Thanks {0} you successfully registered {2} time in issue {1} ;-)", slackRequest.user_name, slackCommand[0], slackCommand[1]));
                    }
                    else
                    {
                        return InternalServerError();
                    }
                }
                catch(Exception ex)
                {
                    return Ok(string.Format("Upp something went wrong {0}", ex));
                }
             
                
            }
        }

        [HttpGet]
        public IHttpActionResult SayHello()
        {
            return Ok("Hola!");
        }

        private string[] DecomposeTextCommand(string text)
        {
            return text.Split(' ');

        }        
    }
}