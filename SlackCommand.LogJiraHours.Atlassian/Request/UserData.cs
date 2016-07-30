using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackCommand.LogJiraHours.Atlassian.Request
{
    public class UserData
    {
        public UserData(string mix)
        {
            this.UserName = mix.Split(':')[0];
            this.Password = mix.Split(':')[1];
        }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
