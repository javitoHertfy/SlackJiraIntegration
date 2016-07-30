using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlackCommand.LogJiraHours.WebApi.Configuration
{
    public class SlackBotConfiguration : ISlackBotConfiguration
    {
      

        private const string SlackTokenKey = "SlackToken";

        public SlackBotConfiguration()
        {
            
            
          
        }

        #region ISlackBotConfiguration Members

        public string SlackToken
        {
            get { return "YOUR_CONFIG_HERE"; }
        }

        #endregion
    }
}
