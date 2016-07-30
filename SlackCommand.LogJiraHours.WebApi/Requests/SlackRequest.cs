using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlackCommand.LogJiraHours.WebApi.Requests
{
    //token=gIkuvaNzQIHg97ATvDxqgjtO
    //team_id=T0001
    //team_domain=example
    //channel_id=C2147483705
    //channel_name=test
    //user_id=U2147483697
    //user_name=Steve
    //command=/weather
    //text=94070
    //response_url=https://hooks.slack.com/commands/1234/5678
    public class SlackRequest
    {
        public string token {get; set;}
        public string team_id { get; set; }
        public string team_domain { get; set; }
        public string channel_id { get; set; }
        public string channel_name { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string command { get; set; }
        public string response_url { get; set; }
        public string text { get; set; }

    }
}
