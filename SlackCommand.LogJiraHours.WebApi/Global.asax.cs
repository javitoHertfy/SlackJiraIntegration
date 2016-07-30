using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using SlackCommand.LogJiraHours.WebApi.App_Start;


namespace SlackCommand.LogJiraHours.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {        
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            ApplicationConfiguration.Load();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            IoCConfig.RegisterDependencies();
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Get the exception object.
            Exception exc = Server.GetLastError();

            // Handle HTTP errors
            if (exc.GetType() != typeof(HttpException))
            {
                logger.Error("Application_Error:Something went wrong", exc);
            }
        }
    }
}
